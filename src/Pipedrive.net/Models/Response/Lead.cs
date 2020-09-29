using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;

using Pipedrive.Internal;

namespace Pipedrive
{
    [JsonConverter(typeof(CustomFieldConverter))]
    public class Lead : IEntityWithCustomFields
    {
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonIgnore]
        public IDictionary<string, ICustomField> CustomFields { get; set; }
    }
}
