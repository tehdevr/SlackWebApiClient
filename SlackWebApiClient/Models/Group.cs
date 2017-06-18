using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class Group : Channel
    {
        
    }

    public class GroupsResponse : Response
    {
        [JsonProperty("groups")]
        public IList<Channel> Groups { get; set; }
    }

    public class GroupResponse : Response
    {
        [JsonProperty("group")]
        public Channel Group { get; set; }
    }
}