using System;
using System.Linq;
using System.Linq.Expressions;

namespace RBev.Xrm.QueryExtensions
{
    internal class CrmQueryProvider : IQueryProvider
    {
        private readonly CrmQueryContext _queryContext;

        public CrmQueryProvider(CrmQueryContext queryContext)
        {
            if (queryContext == null) throw new ArgumentNullException("queryContext");
            _queryContext = queryContext;
        }

        public IQueryable CreateQuery(Expression expression)
        {
            Type elementType = expression.Type.GetEnumerableElementType();
            try
            {
                return (IQueryable)Activator.CreateInstance(typeof(CrmQueryable<>).MakeGenericType(elementType), new object[] { this, expression });
            }
            catch (System.Reflection.TargetInvocationException tie)
            {
                throw tie.InnerException;
            }
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            return new CrmQueryable<TElement>(this, expression);
        }

        public object Execute(Expression expression)
        {
            throw new NotImplementedException();
           // Type elementType = expression.Type.GetEnumerableElementType();
            //return _queryContext.Execute(expression, false);
        }

        public TResult Execute<TResult>(Expression expression)
        {
            return _queryContext.Execute<TResult>(expression);
        }
    }
}