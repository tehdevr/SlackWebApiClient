namespace SlackWebApiClient.Models
{
	public static class ResponseActions
	{
		/// <summary>
		/// Close all views.
		/// </summary>
		public const string Clear = "clear";

		/// <summary>
		/// Errors during processing.
		/// </summary>
		public const string Errors = "errors";

		/// <summary>
		/// Update the existing view.
		/// </summary>
		public const string Update = "update";

		/// <summary>
		/// Push a new view onto the stack.
		/// </summary>
		public const string Push = "push";
	}

}
