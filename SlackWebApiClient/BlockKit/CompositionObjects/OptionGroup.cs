using Newtonsoft.Json;
using System.Collections.Generic;

namespace SlackWebApiClient.Blocks
{
	public class OptionGroup
	{
		public string label { get; set; }
		[JsonProperty(PropertyName = "objects")]
		public List<Option> Options { get; set; }

		public OptionGroup() { }

		public OptionGroup(string label)
		{
			this.label = label;
		}

		public void AddOption(string text, string value)
		{
			if (this.Options == null)
			{
				this.Options = new List<Option>();
			}

			Options.Add(new Option(text, value));
		}
	}
}