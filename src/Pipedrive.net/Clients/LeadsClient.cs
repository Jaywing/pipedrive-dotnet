using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Pipedrive.Clients;
using Pipedrive.Helpers;

namespace Pipedrive
{
    public class LeadsClient : ApiClient, ILeadsClient
    {
        /// <summary>
        /// Initializes a new Lead API client.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public LeadsClient(IApiConnection apiConnection) : base(apiConnection)
        {
        }

        public Task<Lead> Create(NewLead data)
        {
            Ensure.ArgumentNotNull(data, nameof(data));

            return ApiConnection.Post<Lead>(ApiUrls.Leads(), data);
        }
    }
}
