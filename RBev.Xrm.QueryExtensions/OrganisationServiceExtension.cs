using System;
using System.Linq;
using System.Reflection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace RBev.Xrm.QueryExtensions
{
    public static class OrganisationServiceExtension
    {
        public static IQueryable<T> CreateBetterQueryable<T>(this IOrganizationService orgService)
            where T : Entity
        {
            var logicalNameAtt = typeof(T).GetCustomAttributes<EntityLogicalNameAttribute>(true).FirstOrDefault();
            if (logicalNameAtt == null) throw new InvalidOperationException("Could not find EntityLogicalNameAttribute");

            var context = new CrmQueryContext(orgService);
            return new CrmQueryable<T>(new CrmQueryProvider(context));
        }
    }
}