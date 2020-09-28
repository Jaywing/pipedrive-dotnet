using System;
using System.Linq;

using Newtonsoft.Json;

using Pipedrive.Internal;

namespace Pipedrive
{
    [JsonConverter(typeof(CustomFieldConverter))]
    public class Lead
    {
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
