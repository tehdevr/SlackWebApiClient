using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class UsersResponse : Response
    {
        [JsonProperty("users")]
        public IList<User> Users { get; set; }
    }
}