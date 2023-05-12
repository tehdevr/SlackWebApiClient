using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackWebApiClient.Models
{
	public class ModalViewSubmission
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("team")]
		public Team Team { get; set; }

		[JsonProperty("user")]
		public User User { get; set; }

		// Can't do this, too complex of an object (inheritance of Block fouls it up)
		//[JsonProperty("view")]
		//public ModalView View { get; set; }

		[JsonProperty("hash")]
		public string Hash { get; set; }
	}
}
