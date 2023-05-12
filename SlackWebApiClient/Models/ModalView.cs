using Newtonsoft.Json;
using SlackWebApiClient.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackWebApiClient.Models
{
	public class ModalView
	{
		[JsonProperty("type")]
		public string Type { get; set; } = "modal";

		[JsonProperty("title")]
		public PlainText Title { get; set; } = new Blocks.PlainText("Modal Title");

		[JsonProperty("blocks", NullValueHandling = NullValueHandling.Ignore)]
		public List<Block> Blocks { get; set; } = new List<Block>();

		[JsonProperty("close", NullValueHandling = NullValueHandling.Ignore)]
		public PlainText Close { get; set; } = new Blocks.PlainText("Close");

		[JsonProperty("submit", NullValueHandling = NullValueHandling.Ignore)]
		public PlainText Submit { get; set; } = new Blocks.PlainText("Submit");

		[JsonProperty("private_metadata", NullValueHandling = NullValueHandling.Ignore)]
		public string PrivateMetadata { get; set; }

		[JsonProperty("callback_id")]
		public string CallbackID { get; set; }

		[JsonProperty("clear_on_close", NullValueHandling = NullValueHandling.Ignore)]
		public bool ClearOnClose { get; set; } = false;

		[JsonProperty("notify_on_close", NullValueHandling = NullValueHandling.Ignore)]
		public bool NotifyOnClose { get; set; } = false;

		[JsonProperty("external_id")]
		public string ExternalID { get; set; }

		public ModalView(string title = "Modal Title", string close = "Close", string submit = "Submit", string callbackID = "unspec_modal_callback_id")
		{
			if (title == null)
			{
				throw new ArgumentNullException(nameof(title));
			}

			this.Title = new Blocks.PlainText(title);
			

			if (!string.IsNullOrWhiteSpace(close))
			{
				this.Close = new Blocks.PlainText(close);
			}
			else
			{
				this.Close = null;
			}

			if (!string.IsNullOrWhiteSpace(submit))
			{
				this.Submit = new Blocks.PlainText(submit);
			}
			else
			{
				this.Submit = null;
			}

			this.CallbackID = callbackID;
		}
	}

}
