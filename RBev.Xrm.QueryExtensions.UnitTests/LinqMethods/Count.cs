using System.Linq;
using NUnit.Framework;
using RBev.Xrm.QueryExtensions.UnitTests.Context;
using RBev.Xrm.QueryExtensions.UnitTests.Context.Model;

namespace RBev.Xrm.QueryExtensions.UnitTests.LinqMethods
{
    [TestFixture]
    public class CountTests
    {
        [Test]
        public void Count_ExecutesSucessfullyByItself()
        {
            var result = TestOrgContext.Get().CreateBetterQueryable<SystemUser>().Count();
            Assert.That(result, Is.GreaterThan(0));
        }
    }
}