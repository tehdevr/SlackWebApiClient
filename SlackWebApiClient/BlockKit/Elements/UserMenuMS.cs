using Newtonsoft.Json;
using System.Collections.Generic;

namespace SlackWebApiClient.Blocks
{
	public class UserMenuMS : InputElement
	{
		[JsonProperty("initial_users", NullValueHandling = NullValueHandling.Ignore)]
		public List<string> InitialUsers { get; set; }

		[JsonProperty("max_selected_items")]
		public int? MaxSelectedItems { get; set; } = null;



		protected UserMenuMS() : base("multi_users_select", "undef_multi_users_select_element") { }


		public UserMenuMS(string actionID, string placeHolderText = null)
			: base("multi_users_select", actionID, placeHolderText)
		{
		}


	}

}