using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace RBev.Xrm.QueryExtensions.Vistors
{
    public class QueryExpressionBuilder : ExpressionVisitor
    {
        public QueryExpression Query { get; private set; }
        public Type RootEntityType { get; private set; }
        public bool IsCount { get; private set; }
        public Stack<string> MethodStack = new Stack<string>();
        
        public QueryExpression LoadExpression(Expression expression)
        {
            Query = new QueryExpression();
            Query.ColumnSet.AllColumns = true;

            this.Visit(expression);

            return Query;
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            if (node.Type.IsClosedOver(typeof(CrmQueryable<>)))
            {
                RootEntityType = node.Type.GenericTypeArguments[0];
                Query.EntityName = RootEntityType
                    .GetCustomAttribute<EntityLogicalNameAttribute>()
                    .LogicalName;
            }
            return base.VisitConstant(node);
        }


        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            if (node.Method.DeclaringType != typeof (System.Linq.Queryable))
                return base.VisitMethodCall(node);

            switch (node.Method.Name)
            {
                case "Count":
                    return VisitCount(node);
            }

            MethodStack.Push(node.Method.Name);
            var result= base.VisitMethodCall(node);
            MethodStack.Pop();
            return result;
        }

        private Expression VisitSelect(MethodCallExpression node)
        {
            var selector = node.Arguments[1];

            var memberAccesses = new SelectorRequiredAttributeNameExtractor().GetAttributeNames(selector);
            foreach (var memberAccessInfo in memberAccesses)
            {
                Query.ColumnSet.AllColumns = false;

                //todo: support tracking through joins, will also require mapping accesses to joined
                //elements after the query has been resolved.
                Query.ColumnSet.AddColumn(memberAccessInfo.AttributeSchemaName);
                memberAccessInfo.MemberAlias = memberAccessInfo.AttributeSchemaName;
            }

            return base.VisitMethodCall(node);
        }

        protected override Expression VisitConditional(ConditionalExpression node)
        {
            return base.VisitConditional(node);
        }
        
        protected override Expression VisitBinary(BinaryExpression node)
        {
            if (IsConditionalMethodName(MethodStack.Peek()))
            {
                return base.VisitBinary(node);
            }
            return base.VisitBinary(node);
        }

        
        private static bool IsConditionalMethodName(string peek)
        {
            switch (peek)
            {
                case "Where":
                case "Any":
                case "All":
                case "First":
                case "Single":
                case "Last":
                case "SingleOrDefault":
                case "FirstOrDefault":
                case "LastOrDefault":
                    return true;
                default:
                    return false;
            }
        }

        private void SetRowCount(int n)
        {
            if (Query.PageInfo.PageNumber == 0)
                Query.PageInfo.PageNumber = 1;
            Query.PageInfo.Count = 1;
        }

        private Expression VisitCount(MethodCallExpression node)
        {
            if (IsCount) 
                throw new Exception("Multiple calls to Count() shouldn't be possible in a single query");

            //if (node.Arguments.Count > 1)
            //{
            //    //this is the Predicate on Count<T>(IQueryable, Func<T, bool>)
            //    VisitWhereExpression((LambdaExpression) node.Arguments[1]);
            //}

            IsCount = true;
            Query.PageInfo = new PagingInfo();
            Query.PageInfo.PageNumber = 1;
            Query.PageInfo.Count = 1;
            Query.PageInfo.ReturnTotalRecordCount = true;
            Query.ColumnSet.AllColumns = false;

            return base.VisitMethodCall(node);
        }
        

    }
}