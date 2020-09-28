using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pipedrive.Clients
{
    public interface ILeadsClient
    {
        Task<IReadOnlyList<Lead>> GetAll(DealFilters filters);

        Task<Lead> Create(NewLead data);
    }


}
