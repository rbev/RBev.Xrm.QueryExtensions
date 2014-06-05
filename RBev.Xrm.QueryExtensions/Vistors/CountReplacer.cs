using System.Linq.Expressions;

namespace RBev.Xrm.QueryExtensions.Vistors
{
    internal class CountReplacer : ExpressionVisitor
    {
        private readonly int _count;

        public CountReplacer(int count)
        {
            _count = count;
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            if (node.Method.DeclaringType != typeof (System.Linq.Queryable)
                && node.Method.Name == "Count")
                return Expression.Constant(_count);

            return base.VisitMethodCall(node);
        }
    }
}