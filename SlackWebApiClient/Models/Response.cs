using Newtonsoft.Json;
using SlackWebApiClient.Interfaces.Models;
using System.Collections.Generic;

namespace SlackWebApiClient.Models
{
	public class Response : IResponse
	{
		[JsonProperty("ok")]
		public bool Ok { get; set; }

		[JsonProperty("error")]
		public string Error { get; set; }

		[JsonProperty("warning")]
		public string Warning { get; set; }

		[JsonProperty("response_metadata")]
		public Dictionary<string,List<string>> ResponseMetadata { get; set; }
	}
}