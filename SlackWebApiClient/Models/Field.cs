using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
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