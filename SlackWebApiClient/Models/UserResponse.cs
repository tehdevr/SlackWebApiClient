using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class UserResponse : Response
    {
        [JsonProperty("user")]
        public User User { get; set; }
    }
}