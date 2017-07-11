using System.Collections.Generic;
using System.Threading.Tasks;
using SlackWebApiClient.Interfaces;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Implementations
{
    public class Channels : IChannels
    {
        private readonly Client _client;

        public Channels(Client client)
        {
            _client = client;
        }

        public async Task<ChannelsResponse> List()
        {
            const string endpoint = "channels.list";

            return await _client.Post<ChannelsResponse>(endpoint);
        }

        public async Task<ChannelReponse> Info(string channel)
        {
            var url = $"channels.info";

            var body = new Dictionary<string, string>
            {
                {"channel", channel}
            };

            return await _client.Post<ChannelReponse>(url, body);
        }

        public async Task<ChannelReponse> Invite(string channel, string user)
        {
            var url = $"channels.invite";

            var body = new Dictionary<string, string>
            {
                {"channel", channel},
                {"user", user}
            };

            return await _client.Post<ChannelReponse>(url, body);
        }
    }
}