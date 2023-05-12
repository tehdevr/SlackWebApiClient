using System.Collections.Generic;
using System.Threading.Tasks;
using SlackWebApiClient.Interfaces.Methods;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Methods
{
    public class Auth : IAuth
    {
        private readonly Client _client;

        public Auth(Client client)
        {
            _client = client;
        }

        public async Task<AuthTestResponse> Test(string token)
        {
            var endpoint = $"auth.test";
            Dictionary<string, string> parms = new Dictionary<string, string>();
            parms.Add("token", token);

            return await _client.Get<AuthTestResponse>(endpoint, parms);
        }

    }
}