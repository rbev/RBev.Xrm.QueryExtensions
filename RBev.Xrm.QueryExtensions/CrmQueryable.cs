using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RBev.Xrm.QueryExtensions
{
    public class CrmQueryable<T> : IOrderedQueryable<T>
    {
        /// <summary> 
        /// This constructor is called by the client to create the data source. 
        /// </summary> 
        public CrmQueryable(IQueryProvider provider, string entityName)
        {
            Provider = provider;
            Expression = Expression.Constant(this);
            //EntityLogicalName = entityName;
        }

        /// <summary> 
        /// This constructor is called by Provider.CreateQuery(). 
        /// </summary> 
        /// <param name="expression"></param>
        internal CrmQueryable(CrmQueryProvider provider, Expression expression)
        {
            if (provider == null)
            {
                throw new ArgumentNullException("provider");
            }

            if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }

            if (!typeof(IQueryable<T>).IsAssignableFrom(expression.Type))
            {
                throw new ArgumentOutOfRangeException("expression");
            }

            Provider = provider;
            Expression = expression;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (Provider.Execute<IEnumerable<T>>(Expression)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public Expression Expression { get; private set; }
        public Type ElementType { get { return typeof (T); } }
        public IQueryProvider Provider { get; private set; }
        //public string EntityLogicalName { get; private set; }
    }
}
