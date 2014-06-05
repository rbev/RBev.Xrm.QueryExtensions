using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using RBev.Xrm.QueryExtensions.UnitTests.Context;
using RBev.Xrm.QueryExtensions.UnitTests.Context.Model;

namespace RBev.Xrm.QueryExtensions.UnitTests.LinqMethods
{
    [TestFixture]
    public class ToEnumerable
    {
        [Test]
        public void ToList_SucceedsAndIsNotnEmpty()
        {
            var result = TestOrgContext.Get().CreateBetterQueryable<SystemUser>().ToList();
            Assert.That(result, Is.Not.Empty);
            Assert.That(result[0].Attributes.Count, Is.GreaterThan(5));
        }

        [Test]
        public void CAstToEnumerable_SucceedsAndIsNotnEmpty()
        {
            var result = (IEnumerable<SystemUser>)TestOrgContext.Get().CreateBetterQueryable<SystemUser>();
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.First().Attributes.Count, Is.GreaterThan(5));
        }
    }
}