using System.Threading.Tasks;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Interfaces
{
    public interface IMpim
    {
        Task<MpimsResponse> List();
        Task<MessagesResponse> Messages(string channel, string ts = null, string latest = null, string oldest = null, int? count = default(int?), bool inclusive = false, bool unreads = false);
    }
}