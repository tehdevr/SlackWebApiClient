using System.Collections.Generic;

namespace SlackWebApiClient.Models
{

	public abstract class Block
	{
		public virtual string type { get; private set; }
		public string block_id { get; set; }
	}


	public class SectionBlock : Block
	{
		public override string type { get => "section"; }
		public Text text { get; set; }
		public List<Text> fields { get; set; } = new List<Text>();
		public BlockElement accessory { get; set; }
	}


	public class DividerBlock : Block
	{
		public override string type => "divider";
	}


	public class ImageBlock : Block
	{
		public override string type => "image";
		public string image_url { get; set; }
		public string alt_text { get; set; }
		public PlainText title { get; set; }
	}


	public class ActionsBlock : Block
	{
		public override string type => "actions";
		public List<BlockElement> elements { get; set; } = new List<BlockElement>();
	}


	public class ContextBlock : Block
	{
		public override string type => "context";

		/// <summary>List of image elements and text objects.</summary>
		/// <remarks>Block</remarks>
		public List<object> elements { get; set; } = new List<object>();
	}

}