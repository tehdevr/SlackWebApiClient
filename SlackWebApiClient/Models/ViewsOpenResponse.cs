using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class ViewsOpenResponse : Response
    {
		[JsonProperty("view")]
		public ViewsOpenResponseView ResponseView { get; set; }
	}
}