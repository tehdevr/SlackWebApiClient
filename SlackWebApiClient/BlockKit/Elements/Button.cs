using Newtonsoft.Json;

namespace SlackWebApiClient.Blocks
{
	public class Button : InputElement
	{
		[JsonProperty("text")]
		public PlainText Text { get; set; }

		[JsonProperty("value")]
		public string Value { get; set; }

		[JsonProperty("style")]
		public string Style { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		protected Button() { }

		/// <summary>Button /summary>
		/// <param name="text"></param>
		/// <param name="value"></param>
		/// <param name="actionID"></param>
		/// <param name="style">Primary | Danger (leave null for Deafult)</param>
		/// <param name="url"></param>
		public Button(string text, string value, string actionID, string style = ButtonStyle.Default, string url = null)
			: base("button", actionID, null)
		{
			this.Confirm = null;

			this.Text = new PlainText(text);
			this.Url = url;
			this.Value = value;
			this.Style = style;
		}

		public static class ButtonStyle
		{
			public const string Default = null;
			public const string Primary = "primary";
			public const string Danger = "danger";
		}
	}



}