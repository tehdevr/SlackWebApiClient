using Newtonsoft.Json;
using System.Collections.Generic;

namespace SlackWebApiClient.Blocks
{
	public class ExternalMenuMS : InputElement
	{
		[JsonProperty("initial_options", NullValueHandling = NullValueHandling.Ignore)]
		public List<Option> InitialOptions { get; set; }

		[JsonProperty("min_query_length")]
		public int MinQueryLength { get; set; } = 3;

		[JsonProperty("max_selected_items")]
		public int? MaxSelectedItems { get; set; } = null;


		protected ExternalMenuMS() : base("multi_external_select", "undef_multi_external_select_element") { }


		public ExternalMenuMS(string actionID, string placeHolderText = null)
			: base("multi_external_select", actionID, placeHolderText)
		{
		}



	}

}