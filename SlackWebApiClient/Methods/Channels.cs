using System.Collections.Generic;
using System.Threading.Tasks;
using SlackWebApiClient.Interfaces.Methods;
using SlackWebApiClient.Interfaces.Models;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Methods
{
    public class Channels : IChannels
    {
        private readonly Client _client;

        public Channels(Client client)
        {
            _client = client;
        }

        public Task<ChannelResponse> SetTopic(string channel, string topic)
        {
            throw new System.NotImplementedException();
        }

        public Task<ChannelResponse> SetPurpose(string channel, string purpose)
        {
            throw new System.NotImplementedException();
        }

        public Task<ChannelResponse> Rename(string channel, string name, bool? validate = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<ChannelResponse> Kick(string channel, string user)
        {
            throw new System.NotImplementedException();
        }

        public Task<ChannelResponse> Leave(string channel)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ChannelsResponse> List()
        {
            const string endpoint = "channels.list";

            return await _client.Post<ChannelsResponse>(endpoint);
        }

        public async Task<ChannelResponse> Info(string channel)
        {
            var url = $"channels.info";

            var body = new Dictionary<string, string>
            {
                {"channel", channel}
            };

            return await _client.Post<ChannelResponse>(url, body);
        }

        public async Task<ChannelResponse> Invite(string channel, string user)
        {
            var url = $"channels.invite";

            var body = new Dictionary<string, string>
            {
                {"channel", channel},
                {"user", user}
            };

            return await _client.Post<ChannelResponse>(url, body);
        }
    }
}