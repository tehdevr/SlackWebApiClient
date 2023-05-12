using SlackWebApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackWebApiClient.Interfaces.Methods
{
	public interface IOAuth
	{
		Task<OAuthAccessResponse> Access(string code, string clientID, string clientSecret, string redirect_uri = null, bool single_channel = false);
	}
}
