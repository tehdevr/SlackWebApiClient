using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackWebApiClient.Models
{
	public class ViewSubmissionRequest
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("api_app_id")]
		public string ApiAppID { get; set; }

		[JsonProperty("token")]
		public string Token { get; set; }

		[JsonProperty("trigger_id")]
		public string TriggerID { get; set; }

		[JsonProperty("response_urls")]
		public string[] ResponseUrls { get; set; }


		[JsonProperty("view")]
		public ModalView ModalView { get; set; }

	}
}
