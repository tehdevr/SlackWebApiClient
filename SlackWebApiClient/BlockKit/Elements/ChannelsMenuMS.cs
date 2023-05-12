using Newtonsoft.Json;
using System.Collections.Generic;

namespace SlackWebApiClient.Blocks
{
	public class ChannelsMenuMS : InputElement
	{
		[JsonProperty("initial_channels", NullValueHandling = NullValueHandling.Ignore)]
		public List<string> InitialChannels { get; set; }

		[JsonProperty("max_selected_items")]
		public int? MaxSelectedItems { get; set; } = null;



		protected ChannelsMenuMS() : base("multi_channels_select", "undef_multi_channels_select_element") { }


		public ChannelsMenuMS(string actionID, string placeHolderText = null)
			: base("multi_channels_select", actionID, placeHolderText)
		{
		}


	}

}