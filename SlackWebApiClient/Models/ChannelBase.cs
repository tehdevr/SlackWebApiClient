using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class ChannelBase
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }
    }
}