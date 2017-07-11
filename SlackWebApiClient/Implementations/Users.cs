using System.Collections.Generic;
using System.Threading.Tasks;
using SlackWebApiClient.Interfaces;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Implementations
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

            var body = new Dictionary<string, string>
            {
                {"user", user}
            };

            return await _client.Post<UserResponse>(url, body);
        }

        public async Task<PresenceResponse> GetPresence(string user)
        {
            var url = $"users.getPresence";

            var body = new Dictionary<string, string>
            {
                {"user", user}
            };

            return await _client.Post<PresenceResponse>(url, body);
        }
    }
}