using Newtonsoft.Json;

namespace SlackWebApiClient.Blocks
{
	public class ImageBlock : Block
	{
		[JsonProperty("image_url")]
		public string ImageUrl { get; set; }

		[JsonProperty("alt_text")]
		public string AltText { get; set; }

		[JsonProperty("title")]
		public PlainText Title { get; set; }

		public ImageBlock(string blockID = "undef_image_block_id") : base(type: "image", blockID: blockID)
		{
			base.ActionID = null; // Be sure it's cleared, it shouldn't exist on an image block.
		}
	}

}