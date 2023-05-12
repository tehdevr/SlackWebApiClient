using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class ConversationsResponse : Response
    {
        [JsonProperty("channels")]
        public IList<Channel> Channels { get; set; }
    }
}