using Newtonsoft.Json;
using System.Collections.Generic;

namespace SlackWebApiClient.Blocks
{
	public class SectionBlock : Block
	{
		[JsonProperty("text")]
		public MarkdownText Text { get; set; }

		[JsonProperty("fields")]
		public List<MarkdownText> Fields { get; set; } = null;

		[JsonProperty("accessory")]
		public InputElement Accessory { get; set; } = null;

		public SectionBlock(string markdownText = "Section Block", string blockID = "undef_section_block_id") 
			: base(type: "section", blockID: blockID)
		{
			if (!string.IsNullOrWhiteSpace(markdownText))
			{
				this.Text = new MarkdownText(markdownText);
			}
			else
			{
				this.Text = null;
			}
		}
	}


}