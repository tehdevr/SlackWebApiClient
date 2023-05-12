namespace SlackWebApiClient.Blocks
{
	public class Option
	{
		public PlainText text { get; set; }
		public string value { get; set; }

		public Option(string text = "text", string value = "value", bool? emoji = true)
		{
			this.text = new PlainText(text, emoji);
			this.value = value;
		}
	}
}