using Newtonsoft.Json;

namespace SlackWebApiClient.Blocks
{
	/// <summary>
	/// Image Element for inclusion as an element in a Block.
	/// </summary>
	/// <remarks>If you want a block with only an image in it, use an <see cref="ImageBlock"/> </remarks>
	public class Image
	{
		[JsonProperty("type")]
		public string Type { get; private set; } = "image";

		[JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
		public string ImageUrl { get; set; }

		[JsonProperty("alt_text", NullValueHandling = NullValueHandling.Ignore)]
		public string AltText { get; set; }



		public Image(string imageUrl = null, string altText = null)
		{
			this.ImageUrl = imageUrl;
			this.AltText = altText;
		}
	}

}