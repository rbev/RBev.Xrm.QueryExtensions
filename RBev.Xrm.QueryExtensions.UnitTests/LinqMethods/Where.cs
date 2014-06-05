using System.Linq;
using Microsoft.Xrm.Sdk.Query;
using NUnit.Framework;
using RBev.Xrm.QueryExtensions.UnitTests.Context;
using RBev.Xrm.QueryExtensions.UnitTests.Context.Model;

namespace RBev.Xrm.QueryExtensions.UnitTests.LinqMethods
{
    [TestFixture]
    public class Where
    {
        [Test]
        public void Where_Integer_Equals()
        {
            var ctx = new CrmQueryContext(TestOrgContext.Get());

            var query = (CrmQueryable<SystemUser>)TestOrgContext.Get()
                .CreateBetterQueryable<SystemUser>()
                .Where(su => su.TimeZoneRuleVersionNumber == 1);

            var expression = ctx.GetQueryExpression(query.Expression);

            Assert.That(expression.EntityName, Is.EqualTo(SystemUser.EntityLogicalName));
            Assert.That(expression.LinkEntities, Is.Empty);
            Assert.That(expression.Criteria.Conditions, Is.Not.Empty);
            Assert.That(expression.Criteria.Conditions[0].AttributeName, Is.EqualTo("timezoneruleversionnumber"));
            Assert.That(expression.Criteria.Conditions[0].Operator, Is.EqualTo(ConditionOperator.Equal));
            Assert.That(expression.Criteria.Conditions[0].Values, Is.EquivalentTo(new[] { 1 }));
        }
    }
}