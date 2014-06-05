using System.Linq.Expressions;

namespace RBev.Xrm.QueryExtensions.Vistors
{
    public class MemberAccessInfo
    {
        public string AttributeSchemaName { get; set; }
        public string MemberAlias { get; set; }
        public MemberExpression Source { get; set; }
    }
}