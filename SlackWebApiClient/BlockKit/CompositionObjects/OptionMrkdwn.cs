using Newtonsoft.Json;

namespace SlackWebApiClient.Blocks
{
	public class Option2
	{
		[JsonProperty("text")]
		public MarkdownText Text { get; set; }

		[JsonProperty("value")]
		public string Value { get; set; }

		public Option2(string text = "text", string value = "value")
		{
			this.Text = new MarkdownText(text);
			this.Value = value;
		}
	}
}