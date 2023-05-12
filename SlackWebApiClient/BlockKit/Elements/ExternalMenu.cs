using Newtonsoft.Json;
using System.Collections.Generic;

namespace SlackWebApiClient.Blocks
{
	public class ExternalMenu : InputElement
	{
		[JsonProperty("initial_option", NullValueHandling = NullValueHandling.Ignore)]
		public Option InitialOption { get; set; }


		[JsonProperty("min_query_length")]
		public int MinQueryLength { get; set; } = 3;



		protected ExternalMenu() : base("external_select", "undef_external_select_element") { }


		public ExternalMenu(string actionID, string placeHolderText = null)
			: base("external_select", actionID, placeHolderText)
		{
		}


	}

}