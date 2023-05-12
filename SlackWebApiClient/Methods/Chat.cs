using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SlackWebApiClient.Interfaces.Methods;
using SlackWebApiClient.Interfaces.Models;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Methods
{
    public class Chat : IChat
    {
        private readonly Client _client;

        public Chat(Client client)
        {
            _client = client;
        }

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
			bool? replyBroadcast = null,
			IList<Block> blocks = null)
        {
            var url = $"chat.postMessage";

            var body = new Dictionary<string, string>
            {
                {"channel", channel},
                {"text", text}
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
			if (blocks != null) body.Add("blocks", JsonConvert.SerializeObject(blocks));

			return await _client.Post<MessageResponse>(url, body);
        }


        public async Task<MessageResponse> Update(
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
            bool? replyBroadcast = null,
			IList<Block> blocks = null)
        {
            var endpoint = $"chat.update";

            var body = new Dictionary<string, string>
            {
                {"channel", channel},
                {"ts", ts},
                {"text", text}
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

            return await _client.Post<MessageResponse>(endpoint, body);
        }

        public async Task<MessageResponse> Delete(string channel, string ts, bool? asUser = null)
        {
            const string endpoint = "chat.delete";

            var body = new Dictionary<string, string>
            {
                { "channel", channel },
                { "ts", ts }
            };

            if(asUser != null) body.Add("as_user", asUser.ToString());

            return await _client.Post<MessageResponse>(endpoint, body);
        }

        public async Task<MessageResponse> MeMessage(string channel, string text)
        {
            const string endpoint = "chat.meMessage";

            var body = new Dictionary<string, string>
            {
                { "channel", channel },
                { "text", text }
            };

            return await _client.Post<MessageResponse>(endpoint, body);
        }
    }
}