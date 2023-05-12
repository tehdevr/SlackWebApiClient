using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SlackWebApiClient.Interfaces.Methods;
using SlackWebApiClient.Interfaces.Models;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Methods
{
    public class OAuth : IOAuth
    {
        private readonly Client _client;

        public OAuth(Client client)
        {
            _client = client;
        }


        public async Task<OAuthAccessResponse> Access(string code, string clientID, string clientSecret, string redirect_uri = null, bool single_channel = false)
        {
            if (string.IsNullOrWhiteSpace(clientID))
            {
                throw new ArgumentNullException(nameof(clientID));
            }
            if (string.IsNullOrWhiteSpace(clientSecret))
            {
                throw new ArgumentNullException(nameof(clientSecret));
            }

            return await _client.PostOauthAccess(clientID, clientSecret, code, redirect_uri, false);
        }

    }
}