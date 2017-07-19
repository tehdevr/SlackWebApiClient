using System.Threading.Tasks;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Interfaces.Methods
{
    public interface IGroups
    {
        Task<GroupResponse> Info(string group);
        Task<GroupsResponse> List(bool excludeArchive, bool excludeMembers);
        Task<MessagesResponse> Messages(string channel, string ts = null, string latest = null, string oldest = null, int? count = default(int?), bool inclusive = false, bool unreads = false);
        Task<GroupResponse> Invite(string channel, string user);
        Task<Response> Kick(string channel, string user);
    }
}