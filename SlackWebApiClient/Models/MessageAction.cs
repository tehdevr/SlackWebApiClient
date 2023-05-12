using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackWebApiClient.Models
{
	public class MessageAction
	{
		[JsonProperty("type")]
		public string Type { get; set; }  // = "shortcut" for global shortcut, "message_action" for message shortcut

		[JsonProperty("callback_id")]
		public string CallbackID { get; set; }

		[JsonProperty("trigger_id")]
		public string TriggerID { get; set; }

		[JsonProperty("response_url")]
		public string ResponseUrl { get; set; }

		[JsonProperty("user")]
		public MessageActionUser User { get; set; }

		[JsonProperty("channel")]
		public string Channel { get; set; }

		[JsonProperty("team")]
		public MessageActionTeam Team { get; set; }

		[JsonProperty("token")]
		public string Token { get; set; }

		[JsonProperty("message")]
		public MessageActionMessage Message { get; set; }

	}

	public class MessageActionUser
	{
		[JsonProperty("id")]
		public string ID { get; set; }

		[JsonProperty("username")]
		public string Username { get; set; }

		[JsonProperty("team_id")]
		public string TeamID { get; set; }
	}

	public class MessageActionTeam
	{
		[JsonProperty("id")]
		public string ID { get; set; }

		[JsonProperty("domain")]
		public string Domain { get; set; }
	}

	public class MessageActionChannel
	{
		[JsonProperty("id")]
		public string ID { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class MessageActionMessage
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("user")]
		public string User { get; set; }

		[JsonProperty("ts")]
		public string Ts { get; set; }

		[JsonProperty("text")]
		public string Text { get; set; }

	}
}
