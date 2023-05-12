using Newtonsoft.Json;
using SlackWebApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackWebApiClient.Blocks
{
	public class HeaderBlock : Block
	{
		[JsonProperty("text")]
		public PlainText Text { get; set; }


		public HeaderBlock(string text = "Header Block", string blockID = "undef_header_block_id") : base(type: "header", blockID: blockID) { this.Text = new PlainText(text); }
	}
}
