using System.Threading.Tasks;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Interfaces.Methods
{
    public interface IUsers
    {
        Task<PresenceResponse> GetPresence(string user);
        Task<UserResponse> Info(string user);
    }
}