using System.Collections.Generic;
using System.Threading.Tasks;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Implementations
{
    public class Groups
    {
        private readonly Client _client;

        public Groups(Client client)
        {
            _client = client;
        }

        public async Task<GroupsResponse> List()
        {
            var endpoint = $"groups.list";

            return await _client.Post<GroupsResponse>(endpoint);
        }

        public async Task<GroupResponse> Info(string group)
        {
            var url = $"groups.info";

            var body = new Dictionary<string, string>
            {
                {"channel", group}
            };

            return await _client.Post<GroupResponse>(url, body);
        }

        public async Task<MessagesResponse> Messages(
            string channel,
            string ts = null,
            string latest = null,
            string oldest = null,
            int? count = null,
            bool inclusive = false,
            bool unreads = false)
        {
            var endpoint = $"groups.history";

            return await _client.GetMessages<MessagesResponse>(endpoint, channel, ts, latest, oldest, count, inclusive,
                unreads);
        }
    }
}