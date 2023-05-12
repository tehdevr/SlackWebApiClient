using Newtonsoft.Json;
using System;

namespace SlackWebApiClient.Blocks
{
	public class TimePicker : InputElement
	{
		[JsonProperty("initial_time", NullValueHandling = NullValueHandling.Ignore)]
		public string InitialTime { get; set; }



		public TimePicker(string actionID, string placeholderText, string initialTime = null)
			:base("timepicker", actionID, placeholderText)
		{
			this.InitialTime = initialTime;
		}
	}

}