using Newtonsoft.Json;
using System.Collections.Generic;

namespace SlackWebApiClient.Models
{

	public abstract class BlockElement
	{
		public virtual string type { get; private set; }
	}


	public class ActionedBlockElement : BlockElement
	{
		public string action_id { get; set; }
		public ConfirmationDialog confirm { get; set; }
	}


	public class Image : BlockElement
	{
		public override string type => "image";
		public string image_url { get; set; }
		public string alt_text { get; set; }
	}


	public class Button : ActionedBlockElement
	{
		public override string type => "button";
		public Text text { get; set; }
		public string url { get; set; }
		public string value { get; set; }
		public string style { get; set; }
	}


	public class StaticMenu : ActionedBlockElement
	{
		public override string type => "static_select";
		public PlainText placeholder { get; set; }
		[JsonProperty(PropertyName = "options")]
		public List<Option> Options { get; set; } = new List<Option>();
		public List<OptionGroup> option_groups { get; set; }
		public Option initial_option { get; set; }
	}


	public class UserMenu : ActionedBlockElement
	{
		public override string type => "users_select";
		public PlainText placeholder { get; set; }
		public string initial_user { get; set; }
	}


	public class ConversationMenu : ActionedBlockElement
	{
		public override string type => "conversations_select";
		public PlainText placeholder { get; set; }
		public string initial_conversation { get; set; }
	}


	public class ChannelMenu : ActionedBlockElement
	{
		public override string type => "channels_select";
		public PlainText placeholder { get; set; }
		public string initial_channel { get; set; }
	}


	public class OverflowMenu : ActionedBlockElement
	{
		public override string type => "overflow";
		public List<Option> options { get; set; }
	}


	public class DatePicker : ActionedBlockElement
	{
		public override string type => "datepicker";
		public PlainText placeholder { get; set; }
		public string initial_date { get; set; }
	}

}