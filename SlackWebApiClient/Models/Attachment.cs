using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class Attachment
    {
        [JsonProperty("fallback")]
        public string Fallback { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        [JsonProperty("author_link")]
        public string AuthorLink { get; set; }

        [JsonProperty("author_icon")]
        public string AuthorIcon { get; set; }

        [JsonProperty("pretext")]
        public string PreText { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("title_link")]
        public string TitleLink { get; set; }

        [JsonProperty("fields")]
        public IList<Field> Fields { get; set; }

        [JsonProperty("footer")]
        public string Footer { get; set; }

        [JsonProperty("mrkdwn_in")]
        public IList<string> MarkdownIn { get; set; }

        public class Field
        {
            public Field(string title, string value, bool isShort = true)
            {
                Title = title;
                Value = value;
                Short = isShort;
            }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("value")]
            public string Value { get; set; }

            [JsonProperty("short")]
            public bool Short { get; set; }
        }
    }
}