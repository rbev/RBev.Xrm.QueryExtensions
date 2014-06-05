using System.Linq;
using NUnit.Framework;
using RBev.Xrm.QueryExtensions.UnitTests.Context;
using RBev.Xrm.QueryExtensions.UnitTests.Context.Model;

namespace RBev.Xrm.QueryExtensions.UnitTests.LinqMethods
{
    public class FirstSingle
    {
        [Test]
        public void First_NoCondition_ReturnsSingleItem()
        {
            var result = TestOrgContext.Get().CreateBetterQueryable<SystemUser>().First();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Attributes.Count, Is.GreaterThan(5));
        }

        [Test]
        public void Single_NoCondition_ReturnsSingleItem()
        {
            var result = TestOrgContext.Get().CreateBetterQueryable<SystemUser>().First();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Attributes.Count, Is.GreaterThan(5));
        }


        [Test]
        public void FirstOrDefault_NoCondition_ReturnsSingleItem()
        {
            var result = TestOrgContext.Get().CreateBetterQueryable<SystemUser>().First();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Attributes.Count, Is.GreaterThan(5));
        }
    }
}