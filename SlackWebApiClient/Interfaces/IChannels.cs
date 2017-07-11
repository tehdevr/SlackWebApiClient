using System.Threading.Tasks;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Interfaces
{
    public interface IChannels
    {
        Task<ChannelReponse> Info(string channel);
        Task<ChannelReponse> Invite(string channel, string user);
        Task<ChannelsResponse> List();
    }
}