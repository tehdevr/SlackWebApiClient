using Newtonsoft.Json;
using System;

namespace SlackWebApiClient.Blocks
{
	public class DatePicker : InputElement
	{
		[JsonProperty("initial_date", NullValueHandling = NullValueHandling.Ignore)]
		public string InitialDate { get; set; }



		public DatePicker(string actionID, string placeholderText, string initialDate = null)
			:base("datepicker", actionID, placeholderText)
		{
			this.InitialDate = initialDate;
		}
	}

}