using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
	public class AuthTestResponse : Response
	{
		[JsonProperty("user_id")]
		public string UserID { get; set; }

		[JsonProperty("user")]
		public string User { get; set; }

		[JsonProperty("team_id")]
		public string TeamID { get; set; }

		[JsonProperty("team")]
		public string Team { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }
	}
}