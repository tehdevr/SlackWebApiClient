using System.Collections.Generic;
using System.Threading.Tasks;
using SlackWebApiClient.Interfaces.Methods;
using SlackWebApiClient.Interfaces.Models;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Methods
{
    public class Conversations : IConversations
    {
        #region PROPERTIES
        private readonly Client _client;
        #endregion PROPERTIES


        #region CONSTRUCTORS
        public Conversations(Client client)
        {
            _client = client;
        }
        #endregion CONSTRUCTORS


        #region METHODS

        public Task<ChannelResponse> Join(string channelID)
        {
            const string endpoint = "conversations.join";

            var body = new Dictionary<string, object>
            {
                { "channel", channelID }
            };

            return _client.PostJson<ChannelResponse>(endpoint, body);
        }

        #endregion METHODS


        #region FUNCTIONS


        #endregion FUNCTIONS

    }
}