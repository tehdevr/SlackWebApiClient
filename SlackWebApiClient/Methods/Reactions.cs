using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SlackWebApiClient.Interfaces.Methods;
using SlackWebApiClient.Interfaces.Models;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Methods
{
    public class Reactions : IReactions
    {
        private readonly Client _client;

        public Reactions(Client client)
        {
            _client = client;
        }

        public async Task<IResponse> Add(string name, string channel = null, string timestamp = null, string file = null, string fileComment = null)
        {
            const string endpoint = "reactions.add";

            if ( channel == null && timestamp == null && file == null && fileComment == null)
                throw new Exception("You must provide channel and timestamp or file or file comment information.");

            if ( channel == null && timestamp != null || channel != null && timestamp == null)
                throw new Exception("You must provide both a channel and timestamp when not using file or file comment.");

            if ( file != null && fileComment != null)
                throw new Exception("Please provide either a file or a file comment, but not both.");

            var body = new Dictionary<string, string>
            {
                {"name", name }
            };

            if (channel != null)
            {
                body.Add("channel", channel);
                body.Add("timestamp", timestamp);
            }

            if (file != null) body.Add("file", file);
            if (fileComment != null) body.Add("file_comment", fileComment);

            return await _client.Post<Response>(endpoint, body);
        }

        public async Task<MessageResponse> Get(string name, string channel = null, bool? full = null, string timestamp = null, string file = null, string fileComment = null)
        {
            const string endpoint = "reactions.get";

            if (channel == null && timestamp == null && file == null && fileComment == null)
                throw new Exception("You must provide channel and timestamp or file or file comment information.");

            if (channel == null && timestamp != null || channel != null && timestamp == null)
                throw new Exception("You must provide both a channel and timestamp when not using file or file comment.");

            if (file != null && fileComment != null)
                throw new Exception("Please provide either a file or a file comment, but not both.");

            var body = new Dictionary<string, string>
            {
                {"name", name }
            };

            if (channel != null)
            {
                body.Add("channel", channel);
                body.Add("timestamp", timestamp);
            }

            if (file != null) body.Add("file", file);
            if (fileComment != null) body.Add("file_comment", fileComment);
            if (full != null) body.Add("full", full.ToString());

            return await _client.Post<MessageResponse>(endpoint, body);
        }

        public async Task<ReactionsResponse> List(int count, bool? full = null, int? page = null, string user = null)
        {
            const string endpoint = "reactions.list";

            var body = new Dictionary<string, string>
            {
                {"count", count.ToString() }
            };

            if (full != null) body.Add("full", full.ToString());
            if (page != null) body.Add("page", page.ToString());
            if (user != null) body.Add("user", user);

            return await _client.Post<ReactionsResponse>(endpoint, body);
        }

        public async Task<IResponse> Remove(string name, string channel = null, string timestamp = null, string file = null, string fileComment = null)
        {
            const string endpoint = "reactions.remove";

            if (channel == null && timestamp == null && file == null && fileComment == null)
                throw new Exception("You must provide channel and timestamp or file or file comment information.");

            if (channel == null && timestamp != null || channel != null && timestamp == null)
                throw new Exception("You must provide both a channel and timestamp when not using file or file comment.");

            if (file != null && fileComment != null)
                throw new Exception("Please provide either a file or a file comment, but not both.");

            var body = new Dictionary<string, string>
            {
                {"name", name }
            };

            if (channel != null)
            {
                body.Add("channel", channel);
                body.Add("timestamp", timestamp);
            }

            if (file != null) body.Add("file", file);
            if (fileComment != null) body.Add("file_comment", fileComment);

            return await _client.Post<Response>(endpoint, body);
        }
    }
}