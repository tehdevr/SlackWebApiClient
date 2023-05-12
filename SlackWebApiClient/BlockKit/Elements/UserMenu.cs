using Newtonsoft.Json;
using System.Collections.Generic;

namespace SlackWebApiClient.Blocks
{
	public class UserMenu : InputElement
	{
		[JsonProperty("initial_user", NullValueHandling = NullValueHandling.Ignore)]
		public string InitialUser { get; set; }



		protected UserMenu() : base("users_select", "undef_users_select_element") { }


		public UserMenu(string actionID, string placeHolderText = null)
			: base("users_select", actionID, placeHolderText)
		{
		}


	}

}