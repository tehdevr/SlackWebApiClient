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

        /*
         * List Operations
         */
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

        /*
         * Array Operations
         */
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

        private async Task<T> GetMessages<T>(
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

        /*
         * Entity Operations
         */
        public async Task<UserResponse> GetUser(string user)
        {
            var url = $"{_url}/users.info";

            var body = new Dictionary<string, string> { 
                {"token", _token },
                {"user", user }
            };

            return await Post<UserResponse>(url, body);
        }

        public async Task<PresenceResponse> GetUserPresence(string user)
        {
            var url = $"{_url}/users.getPresence";

            var body = new Dictionary<string, string> {
                {"token", _token },
                {"user", user }
            };

            return await Post<PresenceResponse>(url, body);
        }

        public async Task<ChannelReponse> GetChannel(string channel)
        {
            var url = $"{_url}/channels.info";

            var body = new Dictionary<string, string>
            {
                {"token", _token},
                { "channel", channel}
            };

            return await Post<ChannelReponse>(url, body);
        }

        public async Task<GroupResponse> GetGroup(string group)
        {
            var url = $"{_url}/groups.info";

            var body = new Dictionary<string, string>
            {
                {"token", _token},
                { "channel", group}
            };

            return await Post<GroupResponse>(url, body);
        }

        /*
         * Write Operations
         */
        public async Task<MessageResponse> PostMessage(
            string channel, 
            string text, 
            string parse = "none", 
            bool? linkNames = null,
            IList<Attachment> attachments = null,
            bool? unfurlLinks = null, 
            bool? unfurlMedia = null, 
            string username = null, 
            bool? asUser = null, 
            string iconUrl = null, 
            string iconEmoji = null, 
            string threadTs = null, 
            bool? replyBroadcast = null )
        {
            var url = $"{_url}/chat.postMessage";

            var body = new Dictionary<string, string> {
                { "token", _token },
                { "channel", channel},
                { "text", text}
            };

            if (parse != null) body.Add("parse", parse);
            if (linkNames != null) body.Add("link_names", linkNames.ToString());
            if (attachments != null) body.Add("attachments", JsonConvert.SerializeObject(attachments));
            if (unfurlLinks != null) body.Add("unfurl_links", unfurlLinks.ToString());
            if (unfurlMedia != null) body.Add("unfurl_media", unfurlMedia.ToString() );
            if (username != null) body.Add("username", username);
            if (asUser != null) body.Add("as_user", asUser.ToString());
            if (iconUrl != null) body.Add("icon_url", iconUrl);
            if (iconEmoji != null) body.Add("icon_emoji", iconEmoji);
            if (threadTs != null) body.Add("thread_ts", threadTs);
            if (replyBroadcast != null) body.Add("reply_broadcast", replyBroadcast.ToString());

            return await Post<MessageResponse>(url, body);
        }
        
        public async Task<MessageResponse> UpdateMessage(
            string channel,
            string ts,
            string text,
            string parse = "none",
            bool? linkNames = null,
            IList<Attachment> attachments = null,
            bool? unfurlLinks = null,
            bool? unfurlMedia = null,
            string username = null,
            bool? asUser = null,
            string iconUrl = null,
            string iconEmoji = null,
            string threadTs = null,
            bool? replyBroadcast = null)
        {
            var url = $"{_url}/chat.update";

            var body = new Dictionary<string, string> {
                { "token", _token },
                { "channel", channel},
                { "ts", ts },
                { "text", text}
            };

            if (parse != null) body.Add("parse", parse);
            if (linkNames != null) body.Add("link_names", linkNames.ToString());
            if (attachments != null) body.Add("attachments", JsonConvert.SerializeObject(attachments));
            if (unfurlLinks != null) body.Add("unfurl_links", unfurlLinks.ToString());
            if (unfurlMedia != null) body.Add("unfurl_media", unfurlMedia.ToString());
            if (username != null) body.Add("username", username);
            if (asUser != null) body.Add("as_user", asUser.ToString());
            if (iconUrl != null) body.Add("icon_url", iconUrl);
            if (iconEmoji != null) body.Add("icon_emoji", iconEmoji);
            if (threadTs != null) body.Add("thread_ts", threadTs);
            if (replyBroadcast != null) body.Add("reply_broadcast", replyBroadcast.ToString());

            return await Post<MessageResponse>(url, body);
        }

        /*
         * Helper functions
         */
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