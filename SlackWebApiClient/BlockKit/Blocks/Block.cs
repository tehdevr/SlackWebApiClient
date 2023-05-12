using Newtonsoft.Json;

namespace SlackWebApiClient.Blocks
{

	public abstract class Block
	{
		[JsonProperty("type")]
		public virtual string Type { get; private set; }

		[JsonProperty("block_id", NullValueHandling = NullValueHandling.Ignore)]
		public string BlockID { get; set; } = null;

		[JsonProperty("action_id", NullValueHandling = NullValueHandling.Ignore)]
		public string ActionID { get; set; } = null; 



		public Block(string type, string blockID)
		{
			this.Type = type;
			this.BlockID = blockID;
		}
	}

}