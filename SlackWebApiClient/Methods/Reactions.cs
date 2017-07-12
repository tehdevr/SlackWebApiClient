using System.Threading.Tasks;
using SlackWebApiClient.Interfaces.Methods;
using SlackWebApiClient.Interfaces.Models;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Methods
{
    public class Reactions : IReactions
    {
        public Task<IResponse> Add(string name, string channel = null, string timestamp = null, string file = null, string fileComment = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<MessageResponse> Get(string name, string channel = null, bool? fulle = null, string timestamp = null, string file = null,
            string fileComment = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReactionsResponse> List(int count, bool? full = null, int? page = null, string user = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<IResponse> Remove(string name, string channel = null, string timestamp = null, string file = null, string fileComment = null)
        {
            throw new System.NotImplementedException();
        }
    }
}