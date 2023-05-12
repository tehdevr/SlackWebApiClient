using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SlackWebApiClient.Blocks;
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
            bool hasAttachments = attachments != null && attachments.Any();
            bool hasBlocks = blocks != null && blocks.Any();
            bool hasText = !string.IsNullOrWhiteSpace(text);

            // Validation
            if (!hasAttachments &&
                !hasBlocks &&
                !hasText)
            {
                throw new ArgumentException("At least one of attachment/blocks/text is required.");
            }

            // Build up request
            var url = $"chat.postMessage";

            var body = new Dictionary<string, object>
            {
                {"channel", channel}
            };

            // Required (at least one)
            if (attachments != null && attachments.Any()) { body.Add("attachments", attachments); }
            if (blocks != null && blocks.Count > 0) { body.Add("blocks", blocks); }
            if (!string.IsNullOrEmpty(text)) { body.Add("text", text); }

            // Optional
            if (parse != null) body.Add("parse", parse);
            if (linkNames != null) body.Add("link_names", linkNames.ToString());
            if (unfurlLinks != null) body.Add("unfurl_links", unfurlLinks.ToString());
            if (unfurlMedia != null) body.Add("unfurl_media", unfurlMedia.ToString());
            if (username != null) body.Add("username", username);
            if (iconUrl != null) body.Add("icon_url", iconUrl);
            if (iconEmoji != null) body.Add("icon_emoji", iconEmoji);
            if (threadTs != null) body.Add("thread_ts", threadTs);
            if (replyBroadcast != null) body.Add("reply_broadcast", replyBroadcast.ToString());
            // Legacy / deprected
            //if (asUser != null) body.Add("as_user", asUser.ToString());

            // Do the post
            return await _client.PostJson<MessageResponse>(url, body);
        }


        public async Task<MessageResponse> PostEphemeral(
            string channel,
            string user,
            string text,
            string parse = "none",
            bool? linkNames = default(bool?),
            IList<Attachment> attachments = null,
            string username = null,
            bool? asUser = default(bool?),
            string iconUrl = null,
            string iconEmoji = null,
            string threadTs = null,
            IList<Block> blocks = null)
        {
            var url = $"chat.postEphemeral";

            var body = new Dictionary<string, object>
            {
                {"channel", channel},
                {"user", user },
                {"text", text}
            };

            if (parse != null) body.Add("parse", parse);
            if (linkNames != null) body.Add("link_names", linkNames.ToString());
            if (attachments != null && attachments.Count > 0) { body.Add("attachments", attachments); }
            if (username != null) body.Add("username", username);
            if (asUser != null) body.Add("as_user", asUser.ToString());
            if (iconUrl != null) body.Add("icon_url", iconUrl);
            if (iconEmoji != null) body.Add("icon_emoji", iconEmoji);
            if (threadTs != null) body.Add("thread_ts", threadTs);
            if (blocks != null && blocks.Count > 0) { body.Add("blocks", blocks); }

            return await _client.PostJson<MessageResponse>(url, body);
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

            var body = new Dictionary<string, object>
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
            //if (asUser != null) body.Add("as_user", asUser.ToString());
            if (iconUrl != null) body.Add("icon_url", iconUrl);
            if (iconEmoji != null) body.Add("icon_emoji", iconEmoji);
            if (threadTs != null) body.Add("thread_ts", threadTs);
            if (replyBroadcast != null) body.Add("reply_broadcast", replyBroadcast.ToString());
            if (blocks != null && blocks.Count > 0) body.Add("blocks", blocks);

            return await _client.PostJson<MessageResponse>(endpoint, body);
        }

        public async Task<MessageResponse> Delete(string channel, string ts, bool? asUser = null)
        {
            const string endpoint = "chat.delete";

            var body = new Dictionary<string, object>
            {
                { "channel", channel },
                { "ts", ts }
            };

            //if(asUser != null) body.Add("as_user", asUser.ToString());

            return await _client.PostJson<MessageResponse>(endpoint, body);
        }

        public async Task<MessageResponse> MeMessage(string channel, string text)
        {
            const string endpoint = "chat.meMessage";

            var body = new Dictionary<string, object>
            {
                { "channel", channel },
                { "text", text }
            };

            return await _client.PostJson<MessageResponse>(endpoint, body);
        }

        public async Task<PermalinkResponse> GetPermalink(string channel, string message_ts, string token)
        {
            const string endpoint = "chat.getPermalink";

            var body = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("token", token ),
                new KeyValuePair<string,string>("channel", channel ),
                new KeyValuePair<string,string>("message_ts", message_ts )
            };

            return await _client.Get<PermalinkResponse>(endpoint, body);
        }
    }
}