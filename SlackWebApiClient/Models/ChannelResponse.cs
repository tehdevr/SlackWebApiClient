using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class ChannelResponse : Response
    {
        [JsonProperty("channel")]
        public Channel Channel { get; set; }
    }
}