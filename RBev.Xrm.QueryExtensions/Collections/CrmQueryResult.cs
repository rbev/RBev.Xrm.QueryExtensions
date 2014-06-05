using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Client.Services;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;

namespace RBev.Xrm.QueryExtensions.Collections
{
    public class CrmQueryResult<T> : IEnumerable<T> where T : Entity
    {
        private readonly IOrganizationService _service;
        private readonly QueryExpression _query;

        public CrmQueryResult(IOrganizationService service, QueryExpression query)
        {
            _service = service;
            _query = query;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var result = _service.Execute<RetrieveMultipleResponse>(new RetrieveMultipleRequest()
            {
                Query = _query
            });

            return result.EntityCollection.Entities.Select(e => e.ToEntity<T>()).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}