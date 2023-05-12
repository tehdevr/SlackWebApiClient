using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class MessageResponse : Response
    {
        [JsonProperty("ts")]
        public string Ts { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("message")]
        public Message Message { get; set; }
    }
}