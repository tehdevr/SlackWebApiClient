using Newtonsoft.Json;
using System.Collections.Generic;

namespace SlackWebApiClient.Blocks
{
	public class ContextBlock : Block
	{
		/// <summary>List of image elements and text objects.</summary>
		/// <remarks>Block</remarks>
		[JsonProperty("elements")]
		public List<object> Elements { get; set; }

		public ContextBlock(string blockID = "undef_context_block_id")
			: base(type: "context", blockID: blockID)
		{

		}
	}

}