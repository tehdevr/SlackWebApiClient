using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class Team
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

    }
}