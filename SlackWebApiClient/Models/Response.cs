using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class Response
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }
}