using System.Collections.Generic;
using System.Threading.Tasks;
using SlackWebApiClient.Interfaces.Methods;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Methods
{
	public class Users : IUsers
	{
		private readonly Client _client;

		public Users(Client client)
		{
			_client = client;
		}

		public async Task<UserResponse> Info(string user)
		{
			var url = $"users.info";

			var body = new Dictionary<string, object>
			{
				{"user", user}
			};

			return await _client.PostJson<UserResponse>(url, body);
		}

		public async Task<PresenceResponse> GetPresence(string user)
		{
			var url = $"users.getPresence";

			var body = new Dictionary<string, object>
			{
				{"user", user}
			};

			return await _client.PostJson<PresenceResponse>(url, body);
		}


		public async Task<UserIdentityResponse> Identity(string userToken)
		{
			var endpoint = "users.identity";

			var parms = new List<KeyValuePair<string,string>>()
			{
				{ new KeyValuePair<string,string> ("token", userToken) }
			};

			return await _client.Get<UserIdentityResponse>(endpoint, parms);
		}
	}

	
}