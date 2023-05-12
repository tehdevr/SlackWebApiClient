namespace SlackWebApiClient.Models
{
	public class ViewsOpenResponseView
	{
		public string id { get; set; }
		public string team_id { get; set; }
		public string type { get; set; }
		public string private_metadata { get; set; }
		public string callback_id { get; set; }
		public string hash { get; set; }
		public bool? clear_on_close { get; set; }
		public bool? notify_on_close { get; set; }
		public string previous_view_id { get; set; }
		public string root_view_id { get; set; }
		public string app_id { get; set; }
		public string external_id { get; set; }
		public string app_installed_team_id { get; set; }
		public string bot_id { get; set; }



	}

}
