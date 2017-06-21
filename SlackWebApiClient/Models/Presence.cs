using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class PresenceResponse : Response
    {
        [JsonProperty("presence")]
        public string Presence { get; set; }
    }
}
