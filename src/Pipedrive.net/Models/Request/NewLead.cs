using System;
using System.Linq;

using Newtonsoft.Json;

namespace Pipedrive
{
    public class NewLead
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("person_id")]
        public long? PersonId { get; set; }

        [JsonProperty("organization_id")]
        public long? OrgId { get; set; }
    }
}
