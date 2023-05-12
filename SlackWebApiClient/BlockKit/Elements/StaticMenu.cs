using Newtonsoft.Json;
using System.Collections.Generic;

namespace SlackWebApiClient.Blocks
{
	public class StaticMenu : InputElement
	{
		[JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
		public List<Option> Options { get; set; }

		[JsonProperty("option_groups", NullValueHandling = NullValueHandling.Ignore)]
		public List<OptionGroup> OptionGroups { get; set; }

		[JsonProperty("initial_option", NullValueHandling = NullValueHandling.Ignore)]
		public Option InitialOption { get; set; }



		protected StaticMenu() : base("static_select", "undef_staticmenu_element") { }


		public StaticMenu(string actionID, string placeHolderText = null)
			: base("static_select", actionID, placeHolderText)
		{
		}


		public void AddOption(string text, string value, bool? emoji = true)
		{
			if (Options == null)
			{
				Options = new List<Option>();
			}

			Options.Add(new Option(text, value, emoji));
		}
	}

}