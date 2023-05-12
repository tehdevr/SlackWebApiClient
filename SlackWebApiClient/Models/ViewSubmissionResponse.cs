using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackWebApiClient.Models
{
	public class ViewSubmissionResponse
	{
		[JsonProperty("response_action")]
		public string ResponseAction { get; set; } = ResponseActions.Clear;

		[JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string, string> Errors { get; set; } 

		[JsonProperty("view", NullValueHandling = NullValueHandling.Ignore)]
		public ModalView View { get; set; }


		public void AddError(string blockID, string error)
		{
			if (Errors == null)
			{
				Errors = new Dictionary<string, string>();
			}

			Errors[blockID] = error;
		}
	}
}
