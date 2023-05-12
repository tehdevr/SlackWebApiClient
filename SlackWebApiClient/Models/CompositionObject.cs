//using Newtonsoft.Json;
//using System.Collections.Generic;

//namespace SlackWebApiClient.Models
//{
//	public class Text
//	{
//		public virtual string type { get => "mrkdwn"; } 
//		public string text { get; set; }
//		public bool? emoji { get; set; }
//		public bool? verbatim { get; set; }
//	}

//	public class PlainText : Text
//	{
//		public override string type { get => "plain_text"; }
//	}


//	public class Option
//	{
//		public string text { get; set; }
//		public string value { get; set; }
//	}


//	public class OptionGroup
//	{
//		public string label { get; set; }
//		[JsonProperty(PropertyName = "objects")]
//		public List<Option> Options { get; set; } = new List<Option>();
//	}


//	public class ConfirmationDialog
//	{
//		public PlainText title { get; set; }
//		public Text text { get; set; }
//		public PlainText confirm { get; set; }
//		public PlainText deny { get; set; }
//	}
//}