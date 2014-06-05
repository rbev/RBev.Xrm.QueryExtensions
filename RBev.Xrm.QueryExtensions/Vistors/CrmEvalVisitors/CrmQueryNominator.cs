using System.Collections.Generic;
using System.Linq.Expressions;

namespace RBev.Xrm.QueryExtensions.Vistors.CrmEvalVisitors
{
    public class CrmQueryResolver : ExpressionVisitor
    {
          HashSet<Expression> candidates;

        internal CrmQueryResolver(HashSet<Expression> candidates) 
        {
            this.candidates = candidates;
        }

        internal Expression Eval(Expression exp) 
        {
            return this.Visit(exp);
        }


        public override Expression Visit(Expression exp) {
            if (exp == null) {
                return null;
            }

            if (this.candidates.Contains(exp)) {
                return this.Evaluate(exp);
            }

            return base.Visit(exp);
        }

        private Expression Evaluate(Expression exp)
        {
            //this will remove the inner replaceable node and replace it with the server query
            return exp;
        }
    }
}