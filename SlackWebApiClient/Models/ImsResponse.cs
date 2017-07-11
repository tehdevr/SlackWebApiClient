using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class ImsResponse : Response
    {
        [JsonProperty("ims")]
        public IList<Im> Ims { get; set; }
    }
}