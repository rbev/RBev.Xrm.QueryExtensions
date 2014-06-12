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
            if (m.Method.DeclaringType == typeof(Queryable) && m.Method.Name == "Where")
            {
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
            throw new NotSupportedException(string.Format("The method '{0}' is not supported", m.Method.Name));
        }

        protected override Expression VisitUnary(UnaryExpression u)
        {
            switch (u.NodeType)
            {
                case ExpressionType.Not:
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
            if (_filterExpression == null)
                _filterExpression = _queryExpression.Criteria;

            switch (b.NodeType)
            {
                case ExpressionType.AndAlso:
                    if (_filterExpression.Filters.Count == 0)
                        _filterExpression.FilterOperator = LogicalOperator.And;
                    else if (_filterExpression.FilterOperator != LogicalOperator.And)
                        //todo :recurse here
                        _filterExpression.
                    base.Visit(b.Left);
                    base.Visit(b.Right);
                    return b;

                case ExpressionType.OrElse:
                        throw new NotImplementedException();
                    break;
                case ExpressionType.Equal:
                    _condition.Operator = ConditionOperator.Equal;
                    break;
                case ExpressionType.NotEqual:
                    _condition.Operator = ConditionOperator.NotEqual;
                    break;
                case ExpressionType.LessThan:
                    throw new NotImplementedException();
                    // sb.Append(" < ");
                    break;
                case ExpressionType.LessThanOrEqual:
                    // sb.Append(" <= ");
                    break;
                case ExpressionType.GreaterThan:
                    //sb.Append(" > ");
                    break;
                case ExpressionType.GreaterThanOrEqual:
                    //sb.Append(" >= ");
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