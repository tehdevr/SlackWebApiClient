using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackWebApiClient.Blocks
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

		[JsonProperty("blocks")]
		public IList<Block> Blocks { get; set; }

        public Attachment()
        {
            Fields = new List<Field>();
            MarkdownIn = new List<string>();
        }

        public void AddField(string title, string value, bool isShort = true)
        {
            Fields.Add(new Field(title, value, isShort));
        }
    }
}