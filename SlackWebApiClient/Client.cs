using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SlackWebApiClient.Models;

namespace SlackWebApiClient
{
    public class Client
    {
        private readonly string _token;
        private readonly string _url;

        public Client(string token, string apiUrl = "https://slack.com/api")
        {
            _token = token;
            _url = apiUrl;
        }

        public async Task<ChannelsResponse> GetChannelsList()
        {
            var url = $"{_url}/channels.list";

            var body = new Dictionary<string, string> {
                {"token", _token }
            };

            return await Post<ChannelsResponse>(url, body);
        }

        public async Task<GroupsResponse> GetGroupsList()
        {
            var url = $"{_url}/groups.list";

            var body = new Dictionary<string, string> {
                {"token", _token }
            };

            return await Post<GroupsResponse>(url, body);
        }

        public async Task<ImsResponse> GetImList()
        {
            var url = $"{_url}/im.list";

            var body = new Dictionary<string, string> {
                {"token", _token }
            };

            return await Post<ImsResponse>(url, body);
        }

        public async Task<MpimsResponse> GetMpimList()
        {
            var url = $"{_url}/mpim.list";

            var body = new Dictionary<string, string>
            {
                {"token", _token }
            };

            return await Post<MpimsResponse>(url, body);
        }

        public async Task<UserResponse> GetUser(string user)
        {
            var url = $"{_url}/users.info";

            var body = new Dictionary<string, string>
            {
                {"token", _token },
                {"user", user }
            };

            return await Post<UserResponse>(url, body);
        }

        public async Task<MessagesResponse> GetImMessages(
            string channel,
            string ts = null,
            string latest = null,
            string oldest = null,
            int? count = null,
            bool inclusive = false,
            bool unreads = false)
        {
            var endpoint = $"im.history";

            return await GetMessages<MessagesResponse>(endpoint, channel, ts, latest, oldest, count, inclusive, unreads);
        }

        public async Task<MessagesResponse> GetMpimMessages(
            string channel,
            string ts = null,
            string latest = null,
            string oldest = null,
            int? count = null,
            bool inclusive = false,
            bool unreads = false)
        {
            var endpoint = $"mpim.history";

            return await GetMessages<MessagesResponse>(endpoint, channel, ts, latest, oldest, count, inclusive, unreads);
        }

        public async Task<MessagesResponse> GetGroupsMessages(
            string channel,
            string ts = null,
            string latest = null,
            string oldest = null, 
            int? count = null, 
            bool inclusive = false,
            bool unreads = false)
        {
            var endpoint = $"groups.history";

            return await GetMessages<MessagesResponse>(endpoint, channel, ts, latest, oldest, count, inclusive, unreads);
        }

        public async Task<T> GetMessages<T>(
            string endpointUrl,
            string channel,
            string ts = null,
            string latest = null,
            string oldest = null,
            int? count = null,
            bool inclusive = false,
            bool unreads = false) where T : Response
        {
            var url = $"{_url}/{endpointUrl}";

            var body = new Dictionary<string, string> {
                {"token", _token },
                {"channel", channel }
            };

            if (ts != null) body.Add("ts", ts);
            if (latest != null) body.Add("latest", latest);
            if (oldest != null) body.Add("oldest", oldest);
            if (count != null) body.Add("count", count.ToString());
            if (inclusive) body.Add("inclusive", inclusive.ToString());
            if (unreads) body.Add("unreads", unreads.ToString());

            return await Post<T>(url, body);
        }

        public async Task<Response> UpdateMessage(string channel, string ts, string text, IList<Attachment> attachments)
        {
            var url = $"{_url}/chat.update";

            var body = new Dictionary<string, string> {
                { "token", _token },
                { "channel", channel},
                { "ts", ts },
                { "text", text}
            };

            if(attachments != null) body.Add("attachments", JsonConvert.SerializeObject(attachments));

            return await Post<Response>(url, body);
        }

        private static async Task<T> Post<T>(string url, Dictionary<string, string> content = null) where T : Response
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, new FormUrlEncodedContent(content));

                return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }
        }
    }
}