using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class ChannelReponse : Response
    {
        [JsonProperty("channel")]
        public Channel Channel { get; set; }
    }
}