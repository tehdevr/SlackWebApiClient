using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class Message
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("ts")]
        public string Ts { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("is_starred")]
        public bool IsStarred { get; set; }

        [JsonProperty("attachments")]
        public IList<Attachment> Attachments { get; set; }

        [JsonProperty("thread_ts")]
        public string ThreadTs { get; set; }

        [JsonProperty("replies")]
        public IList<MessageReply> Replies { get; set; }

        [JsonProperty("reply_count")]
        public int ReplyCount { get; set; }

        [JsonIgnore]
        public bool IsParent => (ThreadTs == Ts);
    }

    public class MessageResponse : Response
    {
        [JsonProperty("ts")]
        public string Ts { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("messages")]
        public Message Message { get; set; }
    }

    public class MessagesResponse : Response
    {
        [JsonProperty("latest")]
        public string Latest { get; set; }

        [JsonProperty("messages")]
        public IList<Message> Messages { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class MessageReply
    {
        public string User { get; set; }
        public string Ts { get; set; }
    }
}