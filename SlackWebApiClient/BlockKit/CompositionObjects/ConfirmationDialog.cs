namespace SlackWebApiClient.Blocks
{
	public class ConfirmationDialog
	{
		public PlainText title { get; set; }
		public MarkdownText text { get; set; }
		public PlainText confirm { get; set; }
		public PlainText deny { get; set; }

		public ConfirmationDialog() { }
		
		public ConfirmationDialog(string title, string text, string confirmText, string denyText)
		{
			this.title = new PlainText(title);
			this.text = new MarkdownText(text);
			this.confirm = new PlainText(confirmText);
			this.deny = new PlainText(denyText);
		}
	}
}