using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class GroupsResponse : Response
    {
        [JsonProperty("groups")]
        public IList<Channel> Groups { get; set; }
    }
}