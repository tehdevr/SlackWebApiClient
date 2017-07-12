using System.Threading.Tasks;
using SlackWebApiClient.Interfaces.Models;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Interfaces.Methods
{
    public interface IChannels
    {
        Task<ChannelResponse> Info(string channel);
        Task<ChannelResponse> Invite(string channel, string user);
        Task<ChannelsResponse> List();
        Task<ChannelResponse> SetTopic(string channel, string topic);
        Task<ChannelResponse> SetPurpose(string channel, string purpose);
        Task<ChannelResponse> Rename(string channel, string name, bool? validate = default(bool?));
        Task<ChannelResponse> Kick(string channel, string user);
        Task<ChannelResponse> Leave(string channel);
    }
}