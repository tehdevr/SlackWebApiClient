using System.Collections.Generic;
using System.Threading.Tasks;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Interfaces
{
    public interface IClient
    {
        Task<T> GetMessages<T>(string endpoint, string channel, string ts = null, string latest = null, string oldest = null, int? count = default(int?), bool inclusive = false, bool unreads = false) where T : Response;
        Task<T> Post<T>(string endpoint, Dictionary<string, string> content = null) where T : Response;
    }
}