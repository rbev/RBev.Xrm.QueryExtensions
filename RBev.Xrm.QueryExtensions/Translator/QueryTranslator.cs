using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;

namespace RBev.Xrm.QueryExtensions.Translator
{
    public class QueryTranslator : ExpressionVisitor
    {
        private QueryExpression _queryExpression = new QueryExpression();
        private bool _negated;
        private ConditionExpression _condition;
        private FilterExpression _filterExpression;

        public QueryTranslator()
        {

        }

        public QueryExpression Translate(Expression expression)
        {
            this._queryExpression = new QueryExpression();
            this.Visit(expression);
            return _queryExpression;
        }

        private static Expression StripQuotes(Expression e)
        {
            while (e.NodeType == ExpressionType.Quote)
            {
                e = ((UnaryExpression)e).Operand;
            }
            return e;
        }

        protected override Expression VisitMethodCall(MethodCallExpression m)
        {
            if (m.Method.DeclaringType == typeof(Queryable))
            {
                if (m.Method.Name == "Where")
                {
                    if (_queryExpression.Criteria.FilterOperator != LogicalOperator.And
                        && _queryExpression.Criteria.Conditions.Any())
                    {
                        _filterExpression = new FilterExpression();
                        _queryExpression.Criteria.Filters.Add(_filterExpression);
                    }
                    else
                    {
                        _filterExpression = _queryExpression.Criteria;
                    }


                    if (_queryExpression.EntityName == null)
                    {
                        this.Visit(m.Arguments[0]);
                    }
                    else
                        throw new NotImplementedException("Cannot visit a second element type");

                    //        sb.Append(") AS T WHERE ");
                    LambdaExpression lambda = (LambdaExpression)StripQuotes(m.Arguments[1]);
                    this.Visit(lambda.Body);
                    return m;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else if (typeof(IQueryable).IsAssignableFrom(m.Method.ReturnType))
            {
                //evaluate this method call, it should eventually get back down to linq
                return Visit(((IQueryable)Expression.Lambda(m).Compile().DynamicInvoke(null)).Expression);
            }
            throw new NotImplementedException("Method not supported");
        }

        protected override Expression VisitUnary(UnaryExpression u)
        {
            switch (u.NodeType)
            {
                case ExpressionType.Not:
                    throw new NotImplementedException("Write better tests for this one");
                    _negated = !_negated;
                    this.Visit(u.Operand);
                    _negated = !_negated;
                    break;
                default:
                    throw new NotSupportedException(string.Format("The unary operator '{0}' is not supported", u.NodeType));
            }
            return u;
        }

        protected override Expression VisitBinary(BinaryExpression b)
        {
            switch (b.NodeType)
            {
                case ExpressionType.AndAlso:
                    VisitBinaryLogicalOperator(b, LogicalOperator.And);
                    return b;
                case ExpressionType.OrElse:
                    VisitBinaryLogicalOperator(b, LogicalOperator.Or);
                    return b;
                case ExpressionType.Equal:
                    _condition = new ConditionExpression() { Operator = ConditionOperator.Equal };
                    break;
                case ExpressionType.NotEqual:
                    _condition = new ConditionExpression() { Operator = ConditionOperator.NotEqual };
                    break;
                case ExpressionType.LessThan:
                    _condition = new ConditionExpression() { Operator = ConditionOperator.LessThan };
                    break;
                case ExpressionType.LessThanOrEqual:
                    _condition = new ConditionExpression() { Operator = ConditionOperator.LessEqual };
                    break;
                case ExpressionType.GreaterThan:
                    _condition = new ConditionExpression() { Operator = ConditionOperator.GreaterThan };
                    break;
                case ExpressionType.GreaterThanOrEqual:
                    _condition = new ConditionExpression() { Operator = ConditionOperator.GreaterEqual };
                    break;
                default:
                    throw new NotSupportedException(string.Format("The binary operator '{0}' is not supported", b.NodeType));
            }

            this.Visit(b.Left);
            this.Visit(b.Right);

            _queryExpression.Criteria.AddCondition(_condition);
            _condition = null;

            return b;
        }

        private void VisitBinaryLogicalOperator(BinaryExpression b, LogicalOperator logicalOperator)
        {
            //if it's empty just use it
            if (_filterExpression.Filters.Count == 0)
                _filterExpression.FilterOperator = logicalOperator;

            var epression = _filterExpression;
            //we are now in a "and" as part of an "or" chain
            if (_filterExpression.FilterOperator != logicalOperator)
                _filterExpression = new FilterExpression(logicalOperator);

            base.Visit(b.Left);
            base.Visit(b.Right);

            //restore the changed item
            _filterExpression = epression;
        }

        protected override Expression VisitConstant(ConstantExpression c)
        {
            IQueryable q = c.Value as IQueryable;
            if (q != null)
            {
                // assume constant nodes w/ IQueryables are table references
                if (_queryExpression.EntityName == null)
                {
                    _queryExpression.EntityName =
                        q.ElementType.GetCustomAttribute<EntityLogicalNameAttribute>().LogicalName;
                }
                else
                {
                    throw new NotImplementedException("Cannot set element name twice, did you try a join?");
                }

            }
            else if (c.Value == null)
            {
                if (_condition != null)
                    switch (_condition.Operator)
                    {
                        case ConditionOperator.Equal:
                            _condition.Operator = ConditionOperator.Null;
                            break;
                        case ConditionOperator.NotEqual:
                            _condition.Operator = ConditionOperator.NotNull;
                            break;
                        default:
                            throw new NotSupportedException("Cannot compare null using " + _condition.Operator);
                    }
            }
            else
            {
                if (_condition != null)
                    switch (Type.GetTypeCode(c.Value.GetType()))
                    {
                        case TypeCode.Boolean:
                        case TypeCode.String:
                        case TypeCode.Int16:
                        case TypeCode.Int32:
                        case TypeCode.Double:
                        case TypeCode.Decimal:
                            _condition.Values.Add(c.Value);
                            break;
                        case TypeCode.DateTime:
                            _condition.Values.Add(((DateTime)c.Value).ToUniversalTime().ToString("O"));
                            break;
                        case TypeCode.Object:
                        default:
                            throw new NotSupportedException(string.Format("The constant for '{0}' is not supported", c.Value));
                            break;
                    }
            }

            return c;
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            var logicalName = node.Member.GetCustomAttribute<AttributeLogicalNameAttribute>();
            if (_condition != null && logicalName != null)
            {
                _condition.AttributeName = logicalName.LogicalName;
                _condition.EntityName = node.Member.DeclaringType.GetCustomAttribute<EntityLogicalNameAttribute>().LogicalName;
                return node;
            }

            return base.VisitMember(node);
        }

    }
}