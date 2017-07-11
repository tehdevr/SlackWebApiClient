using System.Collections.Generic;
using System.Threading.Tasks;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Interfaces
{
    public interface IChat
    {
        Task<MessageResponse> PostMessage(string channel, string text, string parse = "none", bool? linkNames = default(bool?), IList<Attachment> attachments = null, bool? unfurlLinks = default(bool?), bool? unfurlMedia = default(bool?), string username = null, bool? asUser = default(bool?), string iconUrl = null, string iconEmoji = null, string threadTs = null, bool? replyBroadcast = default(bool?));
        Task<MessageResponse> Update(string channel, string ts, string text, string parse = "none", bool? linkNames = default(bool?), IList<Attachment> attachments = null, bool? unfurlLinks = default(bool?), bool? unfurlMedia = default(bool?), string username = null, bool? asUser = default(bool?), string iconUrl = null, string iconEmoji = null, string threadTs = null, bool? replyBroadcast = default(bool?));
    }
}