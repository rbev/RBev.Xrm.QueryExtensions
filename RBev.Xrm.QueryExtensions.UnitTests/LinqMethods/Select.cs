using System.Linq;
using NUnit.Framework;
using RBev.Xrm.QueryExtensions.UnitTests.Context;
using RBev.Xrm.QueryExtensions.UnitTests.Context.Model;

namespace RBev.Xrm.QueryExtensions.UnitTests.LinqMethods
{
    [TestFixture]
    public class Select
    {
        [Test]
        public void SelectPropertiesFromElem_SingleLevelNonEntity()
        {
            var result = TestOrgContext.Get()
                .CreateBetterQueryable<SystemUser>()
                .Select(su => su.FullName)
                .ToArray();

            Assert.That(result, Has.All.Not.Empty);
        }

        [Test]
        public void SelectPropertiesFromElem_BuildsCorrectQueryExpression()
        {
            var ctx = new CrmQueryContext(TestOrgContext.Get());
            
            var query = (CrmQueryable<string>)TestOrgContext.Get()
                .CreateBetterQueryable<SystemUser>()
                .Select(su => su.FullName);

            var expression = ctx.GetQueryExpression(query.Expression);

            Assert.That(expression.ColumnSet.Columns, Is.Not.Empty);
            Assert.That(expression.ColumnSet.AllColumns, Is.False);
            Assert.That(expression.ColumnSet.Columns.Contains("fullname"));
        }


    }
}