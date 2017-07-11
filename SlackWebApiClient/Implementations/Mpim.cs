using System.Threading.Tasks;
using SlackWebApiClient.Interfaces;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Implementations
{
    public class Mpim : IMpim
    {
        private readonly Client _client;

        public Mpim(Client client)
        {
            _client = client;
        }

        public async Task<MpimsResponse> List()
        {
            var endpoint = $"mpim.list";

            return await _client.Post<MpimsResponse>(endpoint);
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
            var endpoint = $"mpim.history";

            return await _client.GetMessages<MessagesResponse>(endpoint, channel, ts, latest, oldest, count, inclusive,
                unreads);
        }
    }
}