using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class GroupResponse : Response
    {
        [JsonProperty("group")]
        public Channel Group { get; set; }
    }
}