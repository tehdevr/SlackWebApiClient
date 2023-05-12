using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class PermalinkResponse : Response
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }
    }
}