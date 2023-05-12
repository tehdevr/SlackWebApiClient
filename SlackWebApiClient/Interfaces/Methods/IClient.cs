using System.Collections.Generic;
using System.Threading.Tasks;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Interfaces.Methods
{
    public interface IClient
    {
        Task<T> GetMessages<T>(string endpoint, string channel, string ts = null, string latest = null, string oldest = null, int? count = default(int?), bool inclusive = false, bool unreads = false) where T : Response;
        Task<T> PostJson<T>(string endpoint, Dictionary<string, object> content = null, bool suppressBearer = false) where T : Response;
		Task<T> PostForm<T>(string endpoint, List<KeyValuePair<string, string>> content = null, bool supressBearer = false) where T : Response;
    }
}