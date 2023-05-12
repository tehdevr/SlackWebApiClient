using Newtonsoft.Json;
using System.Collections.Generic;

namespace SlackWebApiClient.Blocks
{
	public class ConversationsMenuMS : InputElement
	{
		[JsonProperty("initial_conversations", NullValueHandling = NullValueHandling.Ignore)]
		public List<string> InitialConversations { get; set; }

		[JsonProperty("max_selected_items")]
		public int? MaxSelectedItems { get; set; } = null;



		protected ConversationsMenuMS() : base("multi_conversations_select", "undef_multi_conversations_select_element") { }


		public ConversationsMenuMS(string actionID, string placeHolderText = null)
			: base("multi_conversations_select", actionID, placeHolderText)
		{
		}


	}

}