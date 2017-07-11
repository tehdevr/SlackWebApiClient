using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class Channel : ChannelBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_members")]
        public int NumMembers { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("is_member")]
        public bool IsMember { get; set; }

        [JsonProperty("members")]
        public IList<string> Members { get; set; }
    }
}