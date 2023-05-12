using Newtonsoft.Json;

namespace SlackWebApiClient.Blocks
{
	public class InputElement
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("action_id")]
		public string ActionID { get; set; }

		[JsonProperty("confirm", NullValueHandling = NullValueHandling.Ignore)]
		public ConfirmationDialog Confirm { get; set; } = null;

		[JsonProperty("placeholder", NullValueHandling = NullValueHandling.Ignore)]
		public PlainText Placeholder { get; set; } = null;


		public InputElement(string type = "undef_input_element", string actionID = "undef_action_id", string placeholderText = "Placeholder Text")
		{
			this.Type = type;
			this.ActionID = actionID;
			if (placeholderText == null)
			{
				this.Placeholder = null;
			}
			else
			{
				this.Placeholder = new PlainText(placeholderText);
			}
		}
	}
}