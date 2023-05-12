namespace SlackWebApiClient.Blocks
{
	public class PlainText : MarkdownText
	{
		public override string type { get => "plain_text"; }
		public bool emoji = true;

		public PlainText(string text = "plain text", bool? emoji = true)
		{
			this.text = text;
			this.emoji = emoji ?? true;
		}
	}
}