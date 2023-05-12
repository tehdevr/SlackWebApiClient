using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class Channel : ChannelBase
    {
		//[JsonProperty("id")]
		//public string ID { get; set; }

		[JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_members")]
        public int NumMembers { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("is_member")]
        public bool IsMember { get; set; }

        [JsonProperty("members")]
        public IList<string> Members { get; set; }

        [JsonProperty("topic")]
        public ChannelTopic Topic { get; set; }

        [JsonProperty("purpose")]
        public ChannelPurpose Purpose { get; set; }

		[JsonProperty("priority")]
		public ChannelPurpose Priority { get; set; }

		[JsonProperty("is_channel")]
		public bool IsChannel { get; set; }

		[JsonProperty("is_group")]
		public bool IsGroup { get; set; }

		[JsonProperty("is_im")]
		public bool IsIM { get; set; }

		[JsonProperty("is_archived")]
		public bool IsArchived { get; set; }

		[JsonProperty("is_general")]
		public bool IsGeneral { get; set; }

		[JsonProperty("is_shared")]
		public bool IsShared { get; set; }

		[JsonProperty("is_ext_shared")]
		public bool IsExtShared { get; set; }

		[JsonProperty("is_org_shared")]
		public bool IsOrgShared { get; set; }

		[JsonProperty("is_private")]
		public bool IsPrivate { get; set; }

		[JsonProperty("is_mpim")]
		public bool IsMPIM { get; set; }

		[JsonProperty("is_open")]
		public bool IsOpen { get; set; }

		[JsonProperty("is_user_deleted")]
		public bool IsUserDeleted { get; set; }

	}

	public class ChannelTopic
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("last_set")]
        public long LastSetEpoch { get; set; }
    }

    public class ChannelPurpose
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("last_set")]
        public long LastSetEpoch { get; set; }
    }
}