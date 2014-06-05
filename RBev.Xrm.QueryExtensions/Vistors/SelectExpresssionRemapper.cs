using System;
using System.Linq.Expressions;
using Microsoft.Xrm.Sdk;

namespace RBev.Xrm.QueryExtensions.Vistors
{
    internal class SelectExpresssionRemapper : ExpressionVisitor
    {
        private readonly QueryExpressionBuilder _query;
        private readonly EntityCollection _result;

        internal SelectExpresssionRemapper(QueryExpressionBuilder query)
        {
            if (query == null) throw new ArgumentNullException("query");
            _query = query;
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            return base.VisitParameter(node);
        }

    }
}