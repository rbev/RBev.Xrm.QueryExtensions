using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.Xrm.Sdk;

namespace RBev.Xrm.QueryExtensions.Vistors
{
    internal class SelectorRequiredAttributeNameExtractor : ExpressionVisitor
    {
        private List<MemberAccessInfo> _names;

        public MemberAccessInfo[] GetAttributeNames(Expression exp)
        {
            _names = new List<MemberAccessInfo>();
            this.Visit(exp);
            return _names.ToArray();
        }
        
        protected override Expression VisitMember(MemberExpression node)
        {
            if (typeof (Entity).IsAssignableFrom(node.Expression.Type))
            {
                _names.Add(new MemberAccessInfo
                {
                    AttributeSchemaName = node.Member.GetCustomAttribute<AttributeLogicalNameAttribute>().LogicalName,
                    Source = node
                });
            }
            return base.VisitMember(node);
        }
    }
}