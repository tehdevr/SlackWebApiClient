using Newtonsoft.Json;
using System.Collections.Generic;

namespace SlackWebApiClient.Blocks
{
	public class ChannelsMenu : InputElement
	{
		[JsonProperty("initial_channel", NullValueHandling = NullValueHandling.Ignore)]
		public string InitialChannel { get; set; }



		protected ChannelsMenu() : base("channels_select", "undef_channels_select_element") { }


		public ChannelsMenu(string actionID, string placeHolderText = null, string initialChannel = null)
			: base("channels_select", actionID, placeHolderText)
		{
			// Placeholder handled in base

			if (!string.IsNullOrWhiteSpace(initialChannel))
			{
				this.InitialChannel = initialChannel;
			}
		}


	}

}