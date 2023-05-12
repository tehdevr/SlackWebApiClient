using Newtonsoft.Json;
using System.Collections.Generic;

namespace SlackWebApiClient.Blocks
{
	public class ActionsBlock : Block
	{
		[JsonProperty("elements")]
		public List<InputElement> Elements { get; set; }

		public ActionsBlock(string blockID) : base(type: "actions", blockID: blockID) { }
	}

}