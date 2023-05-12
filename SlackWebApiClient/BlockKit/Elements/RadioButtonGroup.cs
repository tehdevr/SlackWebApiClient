using Newtonsoft.Json;
using System.Collections.Generic;


namespace SlackWebApiClient.Blocks
{
	public class RadioButtonGroup : InputElement
	{
		[JsonProperty("options")]
		public List<Option> Options { get; set; } = new List<Option>();

		[JsonProperty("initial_option", NullValueHandling = NullValueHandling.Ignore)]
		public Option InitialOption { get; set; }



		public RadioButtonGroup(string actionID = null)
			: base("radio_buttons", actionID ?? "undef_radio_buttons_action_id", null)
		{
		}
	}
}
