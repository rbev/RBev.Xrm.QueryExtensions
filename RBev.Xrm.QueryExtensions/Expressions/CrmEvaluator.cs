using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using RBev.Xrm.QueryExtensions.Collections;
using RBev.Xrm.QueryExtensions.Vistors;

namespace RBev.Xrm.QueryExtensions.Expressions
{
    public class CrmEvaluator
    {
        public static Expression PartialEval(Expression expression, CrmQueryContext context)
        {
            expression = Evaluator.PartialEval(expression);

            var serverEvaluatable = new Nominator(e => CanServerEvaluate(e, context)).Nominate(expression);

            foreach (var eval in serverEvaluatable)
            {
                var queryExpressionBuilder = new QueryExpressionBuilder();
                queryExpressionBuilder.LoadExpression(eval);

                if (queryExpressionBuilder.IsCount)
                    throw
                        new NotImplementedException(
                            "Need to implement things that can't be handed to linq-to-objects on the retrieve multiple");

                var replacer = new CrmExpressionReplacer(queryExpressionBuilder, eval, context.OrganisationService);
                expression = replacer.Visit(expression);
            }

            return expression;
        }

        public static bool CanServerEvaluate(Expression expression, CrmQueryContext context)
        {
            //todo: this might get quite complex, i think it's the wrong way of doing it.
            if (expression.NodeType == ExpressionType.Constant
                && expression.Type.IsClosedOver(typeof (CrmQueryable<>)))
            {
                return true;

                //var e = (ConstantExpression) expression;
                //var provider = (((IQueryable) e.Value).Provider as CrmQueryProvider;
                //return provider. == context; ;
            }

            return false;
        }

        private class CrmExpressionReplacer : ExpressionVisitor
        {
            private readonly QueryExpressionBuilder _queryExpressionBuilder;
            private readonly Expression _toReplace;
            private readonly IOrganizationService _organisationService;

            public CrmExpressionReplacer(QueryExpressionBuilder queryExpressionBuilder, Expression toReplace,
                IOrganizationService organisationService)
            {
                _queryExpressionBuilder = queryExpressionBuilder;
                _toReplace = toReplace;
                _organisationService = organisationService;
            }

            public override Expression Visit(Expression node)
            {
                if (node == _toReplace)
                {
                    dynamic e = Activator.CreateInstance(typeof (CrmQueryResult<>)
                        .MakeGenericType(_queryExpressionBuilder.RootEntityType),
                        new object[] {_organisationService, _queryExpressionBuilder.Query})
                        ;

                    return GetQueryableConstant(e);
                }

                return base.Visit(node);
            }

            //todo: do some performance investigation about doing this using dynamic, or reflection
            private Expression GetQueryableConstant<T>(IEnumerable<T> enumerable)
            {
                return Expression.Constant(enumerable.AsQueryable());
            }
        }
    }
}