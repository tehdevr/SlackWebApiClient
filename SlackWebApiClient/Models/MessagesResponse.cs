using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class MessagesResponse : Response
    {
        [JsonProperty("latest")]
        public string Latest { get; set; }

        [JsonProperty("messages")]
        public IList<Message> Messages { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }
}