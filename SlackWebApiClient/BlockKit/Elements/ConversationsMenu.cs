using Newtonsoft.Json;
using System.Collections.Generic;

namespace SlackWebApiClient.Blocks
{
	public class ConversationsMenu : InputElement
	{
		[JsonProperty("initial_conversation", NullValueHandling = NullValueHandling.Ignore)]
		public string InitialConversation { get; set; }

		[JsonProperty("default_to_current_conversation")]
		public bool DefaultToCurrentConversation { get; set; }

		[JsonProperty("response_url_enabled")]
		public bool ResponseUrlEnabled { get; set; }

		[JsonProperty("filter")]
		public ConversationsMenuFilter Filter { get; set; }


		protected ConversationsMenu() : base("conversations_select", "undef_conversations_select_element") { }
		

		public ConversationsMenu(string actionID, string placeHolderText = null)
			: base("conversations_select", actionID, placeHolderText)
		{
		}


	}

	public class ConversationsMenuFilter
	{
		[JsonProperty("include")]
		public string[] Include { get; set; }

		[JsonProperty("exclude_external_shared_channels")]
		public bool ExcludeExternalSharedChannels { get; set; }

		[JsonProperty("exclude_bot_users")]
		public bool ExcludeBotUsers { get; set; }
	}
}