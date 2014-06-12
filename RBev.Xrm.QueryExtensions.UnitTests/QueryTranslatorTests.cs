using System.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Moq;
using NUnit.Framework;
using RBev.Xrm.QueryExtensions.Translator;
using RBev.Xrm.QueryExtensions.UnitTests.Context.Model;

namespace RBev.Xrm.QueryExtensions.UnitTests
{
    [TestFixture]
    public class QueryTranslatorTests
    {
        [Test]
        public void TranslatorTranslatesRootQueryable()
        {
            var qt = new QueryTranslator();

            var query =
            Mock.Of<IOrganizationService>().CreateBetterQueryable<SystemUser>();
            var queryExpresion = qt.Translate(query.Expression);


            Assert.That(queryExpresion, Is.Not.Null);
            Assert.That(queryExpresion.EntityName, Is.EqualTo("systemuser"));
        }

        [Test]
        public void Where_SingleClause_RHS()
        {
            var qt = new QueryTranslator();

            var query =
                Mock.Of<IOrganizationService>()
                    .CreateBetterQueryable<SystemUser>()
                    .Where(x => x.FirstName == "hello");
            var queryExpresion = qt.Translate(query.Expression);

            Assert.That(queryExpresion.EntityName, Is.EqualTo("systemuser"));
            Assert.That(queryExpresion.Criteria.Conditions, Is.Not.Empty);
            Assert.That(queryExpresion.Criteria.Conditions.Count, Is.EqualTo(1));
            Assert.That(queryExpresion.Criteria.Conditions[0].AttributeName, Is.EqualTo("firstname"));
            Assert.That(queryExpresion.Criteria.Conditions[0].Operator, Is.EqualTo(ConditionOperator.Equal));
            Assert.That(queryExpresion.Criteria.Conditions[0].Values, Is.EquivalentTo(new object[] { "hello" }));

        }

        [Test]
        public void Where_OrClause_RHS()
        {
            var qt = new QueryTranslator();

            var query =
                Mock.Of<IOrganizationService>()
                    .CreateBetterQueryable<SystemUser>()
                    .Where(x => x.FirstName == "hello" || "2" != x.LastName);
            var queryExpresion = qt.Translate(query.Expression);

            Assert.That(queryExpresion.EntityName, Is.EqualTo("systemuser"));
            Assert.That(queryExpresion.Criteria.Conditions, Is.Not.Empty);
            Assert.That(queryExpresion.Criteria.Conditions.Count, Is.EqualTo(2));

            Assert.That(queryExpresion.Criteria.FilterOperator, Is.EqualTo(LogicalOperator.Or));
            
            Assert.That(queryExpresion.Criteria.Conditions[0].AttributeName, Is.EqualTo("firstname"));
            Assert.That(queryExpresion.Criteria.Conditions[0].Operator, Is.EqualTo(ConditionOperator.Equal));
            Assert.That(queryExpresion.Criteria.Conditions[0].Values, Is.EquivalentTo(new object[] { "hello" }));

            Assert.That(queryExpresion.Criteria.Conditions[1].AttributeName, Is.EqualTo("lastname"));
            Assert.That(queryExpresion.Criteria.Conditions[1].Operator, Is.EqualTo(ConditionOperator.NotEqual));
            Assert.That(queryExpresion.Criteria.Conditions[1].Values, Is.EquivalentTo(new object[] { "2" }));

        }
    }
}