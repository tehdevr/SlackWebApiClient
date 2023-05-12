using Newtonsoft.Json;

namespace SlackWebApiClient.Blocks
{
	public class MarkdownText
	{
		public virtual string type { get => "mrkdwn"; }
		public string text { get; set; }
		//public bool? emoji { get; set; } = null;
		//public bool? verbatim { get; set; }

		public MarkdownText(string text = "Markdown Text")
		{
			this.text = text;
		}

	}
}