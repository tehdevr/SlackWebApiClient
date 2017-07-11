using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class PresenceResponse : Response
    {
        [JsonProperty("presence")]
        public string Presence { get; set; }
    }
}