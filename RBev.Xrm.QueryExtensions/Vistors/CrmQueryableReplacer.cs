using System.Linq;
using System.Linq.Expressions;
using Microsoft.Xrm.Sdk;

namespace RBev.Xrm.QueryExtensions.Vistors
{
    public class CrmQueryableReplacer<T> : ExpressionVisitor 
        where T : Entity
    {
        private readonly EntityCollection _entityCollection;

        public CrmQueryableReplacer(EntityCollection localQueryable)
        {
            this._entityCollection = localQueryable;
        }

        protected override Expression VisitConstant(ConstantExpression c)
        {
            // Replace the constant QueryableTerraServerData arg with the queryable Place collection. 
            if (c.Type == typeof(CrmQueryable<T>))
                return Expression.Constant(this._entityCollection.Entities.Select(e => e.ToEntity<T>()).AsQueryable());
            else
                return c;
        }
    }
}