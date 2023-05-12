using Newtonsoft.Json;

namespace SlackWebApiClient.Blocks
{
	public class PlainTextInputElement : InputElement
	{
		[JsonProperty("initial_value", NullValueHandling = NullValueHandling.Ignore)]
		public string InitialValue { get; set; }

		[JsonProperty("multiline")]
		public bool Multiline { get; set; } = false;

		[JsonProperty("min_length", NullValueHandling = NullValueHandling.Ignore)]
		public int? MinLength { get; set; } = null;

		[JsonProperty("max_length", NullValueHandling = NullValueHandling.Ignore)]
		public int? MaxLength { get; set; } = null;



		protected PlainTextInputElement()
			:base("plain_text_input")
		{
			this.Confirm = null;
		}

		public PlainTextInputElement(string actionID, string placeholderText, string initialValue = null)
			: base ("plain_text_input", actionID, placeholderText)
		{
			this.Confirm = null;
			if (!string.IsNullOrWhiteSpace(initialValue))
			{
				this.InitialValue = initialValue;
			}
		}
	}

}
