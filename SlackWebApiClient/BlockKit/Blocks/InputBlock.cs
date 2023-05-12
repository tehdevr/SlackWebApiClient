using Newtonsoft.Json;


namespace SlackWebApiClient.Blocks
{
	public class InputBlock : Block
	{
		[JsonProperty("element")]
		public InputElement Element { get; set; }

		[JsonProperty("label")]
		public PlainText Label { get; set; }

		[JsonProperty("hint", NullValueHandling = NullValueHandling.Ignore)]
		public PlainText Hint { get; set; }

		[JsonProperty("optional", NullValueHandling = NullValueHandling.Ignore)]
		public bool Optional { get; set; }

		public InputBlock(string label, string blockID) : base(type: "input", blockID: blockID)
		{
			this.Label = new PlainText(label);
		}
	}

}
