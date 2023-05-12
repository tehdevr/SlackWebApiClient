using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
	public class UserIdentityResponse : Response
	{
		[JsonProperty("user")]
		public User User { get; set; }

		[JsonProperty("team")]
		public Team Team { get;set;}
    }
}