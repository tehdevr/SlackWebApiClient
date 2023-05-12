using Newtonsoft.Json;
using System.Collections.Generic;

namespace SlackWebApiClient.Blocks
{
	public class OverflowMenu : InputElement
	{
		[JsonProperty("options")]
		public List<Option> Options { get; set; } = new List<Option>();
			   


		public OverflowMenu(string actionID = null)
			: base("overflow", actionID ?? "undef_overflow_action_id", null)
		{
		}
	}

}