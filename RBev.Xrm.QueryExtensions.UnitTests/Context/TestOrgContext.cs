using Microsoft.Xrm.Client.Configuration;
using Microsoft.Xrm.Sdk;

namespace RBev.Xrm.QueryExtensions.UnitTests.Context
{
    public class TestOrgContext
    {
        public static IOrganizationService Get()
        {
            Microsoft.Xrm.Sdk.IOrganizationService orgservice = CrmConfigurationManager.CreateService("TestConnection");
            return orgservice;
        }
    }
}