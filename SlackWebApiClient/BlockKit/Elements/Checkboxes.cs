using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SlackWebApiClient.Blocks;
using System.Collections.Generic;
using System.Globalization;


namespace SlackWebApiClient.Blocks
{

	public class Checkboxes : InputElement
	{
		[JsonProperty("options")]
		public List<Option> Options { get; set; } = new List<Option>();

		[JsonProperty("initial_options", NullValueHandling = NullValueHandling.Ignore)]
		public List<Option> InitialOptions { get; set; }



		public Checkboxes(string actionID = null)
			:base("checkboxes", actionID ?? "undef_checkboxes_action_id", null)
		{
		}
	}

}
