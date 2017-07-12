using System.Threading.Tasks;
using SlackWebApiClient.Interfaces.Models;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Interfaces.Methods
{
    public interface IReactions
    {
        Task<IResponse> Add(string name, string channel = null, string timestamp = null, string file = null, string fileComment = null);
        Task<MessageResponse> Get(string name, string channel = null, bool? full = default(bool?), string timestamp = null, string file = null, string fileComment = null);
        Task<ReactionsResponse> List(int count, bool? full = default(bool?), int? page = default(int?), string user = null);
        Task<IResponse> Remove(string name, string channel = null, string timestamp = null, string file = null, string fileComment = null);
    }
}