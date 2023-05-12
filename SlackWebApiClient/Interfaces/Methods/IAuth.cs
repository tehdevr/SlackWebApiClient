using System.Collections.Generic;
using System.Threading.Tasks;
using SlackWebApiClient.Interfaces.Models;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Interfaces.Methods
{
	public interface IAuth
	{
		Task<AuthTestResponse> Test(string token);
	}
}