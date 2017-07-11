using System.Threading.Tasks;
using SlackWebApiClient.Interfaces;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Implementations
{
    public class Im : IIm
    {
        private readonly Client _client;

        public Im(Client client)
        {
            _client = client;
        }

        public async Task<ImsResponse> List()
        {
            var endpoint = $"im.list";

            return await _client.Post<ImsResponse>(endpoint);
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
            var endpoint = $"im.history";

            return await _client.GetMessages<MessagesResponse>(endpoint, channel, ts, latest, oldest, count, inclusive,
                unreads);
        }
    }
}