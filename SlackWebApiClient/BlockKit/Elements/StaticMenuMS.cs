using Newtonsoft.Json;
using System.Collections.Generic;

namespace SlackWebApiClient.Blocks
{
	public class StaticMenuMS : InputElement
	{
		[JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
		public List<Option> Options { get; set; }

		[JsonProperty("option_groups", NullValueHandling = NullValueHandling.Ignore)]
		public List<OptionGroup> OptionGroups { get; set; }

		[JsonProperty("initial_options", NullValueHandling = NullValueHandling.Ignore)]
		public List<Option> InitialOptions { get; set; }

		[JsonProperty("max_selected_items")]
		public int? MaxSelectedItems { get; set; } = null;



		protected StaticMenuMS() : base("multi_static_select", "undef_staticmenums_element") { }


		public StaticMenuMS(string actionID, string placeHolderText = null)
			: base("multi_static_select", actionID, placeHolderText)
		{
		}


		public void AddOption(string text, string value)
		{
			if (Options == null)
			{
				Options = new List<Option>();
			}

			Options.Add(new Option(text, value));
		}
	}

}