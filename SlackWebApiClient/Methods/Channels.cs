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

        public async Task<ChannelResponse> SetTopic(string channel, string topic)
        {
            const string endpoint = "channels.leave";

            var body = new Dictionary<string, string>
            {
                {"channel", channel},
                {"topic", topic }
            };

            return await _client.Post<ChannelResponse>(endpoint, body);
        }

        public async Task<ChannelResponse> SetPurpose(string channel, string purpose)
        {
            const string endpoint = "channels.leave";

            var body = new Dictionary<string, string>
            {
                {"channel", channel},
                {"purpose", purpose }
            };

            return await _client.Post<ChannelResponse>(endpoint, body);
        }

        public async Task<ChannelResponse> Rename(string channel, string name, bool? validate = null)
        {
            const string endpoint = "channels.leave";

            var body = new Dictionary<string, string>
            {
                {"channel", channel},
                {"name", name }
            };

            if(validate != null) body.Add("validate", validate.ToString());
            
            return await _client.Post<ChannelResponse>(endpoint, body);
        }

        public async Task<ChannelResponse> Kick(string channel, string user)
        {
            const string endpoint = "channels.kick";

            var body = new Dictionary<string, string>
            {
                {"channel", channel},
                {"user", user }
            };

            return await _client.Post<ChannelResponse>(endpoint, body);
        }

        public async Task<ChannelResponse> Leave(string channel)
        {
            const string endpoint = "channels.leave";

            var body = new Dictionary<string, string>
            {
                {"channel", channel}
            };

            return await _client.Post<ChannelResponse>(endpoint, body);
        }

        public async Task<ChannelsResponse> List()
        {
            const string endpoint = "channels.list";

            return await _client.Post<ChannelsResponse>(endpoint);
        }

        public async Task<ChannelResponse> Info(string channel)
        {
            const string endpoint = "channels.info";

            var body = new Dictionary<string, string>
            {
                {"channel", channel}
            };

            return await _client.Post<ChannelResponse>(endpoint, body);
        }

        public async Task<ChannelResponse> Invite(string channel, string user)
        {
            const string endpoint = "channels.invite";

            var body = new Dictionary<string, string>
            {
                {"channel", channel},
                {"user", user}
            };

            return await _client.Post<ChannelResponse>(endpoint, body);
        }
    }
}