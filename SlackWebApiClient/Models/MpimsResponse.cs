using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class MpimsResponse : Response
    {
        [JsonProperty("mpims")]
        public IList<Message> Mpims { get; set; }
    }
}