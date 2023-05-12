using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
	public class OAuthResponse : Response
	{
	}


	public class OAuthAccessResponse : OAuthResponse
	{
		[JsonProperty("access_token")]
		public string AccessToken { get; set; }

		[JsonProperty("scope")]
		public string Scope { get; set; }

		[JsonProperty("team_id")]
		public string TeamID { get; set; }

		[JsonProperty("team_name")]
		public string TeamName { get; set; }
	}
}