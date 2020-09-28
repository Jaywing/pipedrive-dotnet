using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Pipedrive.Clients;

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

        public Task<IReadOnlyList<Lead>> GetAll(DealFilters filters)
        {
            throw new System.NotImplementedException();
        }

        public Task<Lead> Create(NewLead data)
        {
            throw new System.NotImplementedException();
        }
    }
}
