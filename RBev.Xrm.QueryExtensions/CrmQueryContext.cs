using System;
using System.Linq.Expressions;
using Microsoft.Xrm.Client.Services;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using RBev.Xrm.QueryExtensions.Expressions;
using RBev.Xrm.QueryExtensions.Vistors;

namespace RBev.Xrm.QueryExtensions
{
    public class CrmQueryContext
    {
        private readonly IOrganizationService _organisationService;

        public CrmQueryContext(IOrganizationService organisationService)
        {
            _organisationService = organisationService;
        }

        public IOrganizationService OrganisationService
        {
            get { return _organisationService; }
        }

        public QueryExpression GetQueryExpression(Expression expression)
        {
            var builder = new QueryExpressionBuilder();
            builder.LoadExpression(expression);
            return builder.Query;
        }

        // Executes the expression tree that is passed to it. 
        internal TResult Execute<TResult>(Expression expression)
        {
            // The expression must represent a query over the data source. 
            //if (!IsQueryOverDataSource(expression))
            //    throw new InvalidProgramException("No query over the data source was specified.");

            //Evaluator.PartialEval(expression);

            var builder = new QueryExpressionBuilder();
            builder.LoadExpression(expression);

            var result = _organisationService.Execute<RetrieveMultipleResponse>(new RetrieveMultipleRequest()
            {
                Query = builder.Query
            });

            if (builder.IsCount)
            {
                return (TResult)(object)result.EntityCollection.TotalRecordCount;
            }

            //todo: need a way of doing this without reflection, since we don't have that <T> in here
            var replacer = (ExpressionVisitor)Activator.CreateInstance(typeof(CrmQueryableReplacer<>)
                .MakeGenericType(builder.RootEntityType),
                new object[] { result.EntityCollection });

            return (TResult)Expression.Lambda(expression).Compile().DynamicInvoke();
        }

        private bool IsQueryOverDataSource(Expression expression)
        {
            // If expression represents an unqueried IQueryable data source instance, 
            // expression is of type ConstantExpression, not MethodCallExpression. 
            return !(expression is ConstantExpression && expression.Type.IsClosedOver(typeof(CrmQueryable<>)));
        }

    }
}