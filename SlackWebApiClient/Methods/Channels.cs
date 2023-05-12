using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using SlackWebApiClient.Interfaces.Methods;
using SlackWebApiClient.Interfaces.Models;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Methods
{
 //   public class Channels : IChannels
 //   {
 //       private readonly Client _client;

 //       public Channels(Client client)
 //       {
 //           _client = client;
 //       }

 //       public async Task<ChannelResponse> SetTopic(string channel, string topic)
 //       {
 //           const string endpoint = "channels.setTopic";

 //           var body = new Dictionary<string, object>
 //           {
 //               {"channel", channel},
 //               {"topic", topic }
 //           };

 //           return await _client.PostJson<ChannelResponse>(endpoint, body);
 //       }

 //       public async Task<ChannelResponse> SetPurpose(string channel, string purpose)
 //       {
 //           const string endpoint = "channels.setPurpose";

 //           var body = new Dictionary<string, object>
 //           {
 //               {"channel", channel},
 //               {"purpose", purpose }
 //           };

 //           return await _client.PostJson<ChannelResponse>(endpoint, body);
 //       }

 //       public async Task<ChannelResponse> Rename(string channel, string name, bool? validate = null)
 //       {
 //           const string endpoint = "channels.rename";

 //           var body = new Dictionary<string, object>
 //           {
 //               {"channel", channel},
 //               {"name", name }
 //           };

 //           if(validate != null) body.Add("validate", validate.ToString());
            
 //           return await _client.PostJson<ChannelResponse>(endpoint, body);
 //       }

 //       public async Task<ChannelResponse> Kick(string channel, string user)
 //       {
 //           const string endpoint = "channels.kick";

 //           var body = new Dictionary<string, object>
 //           {
 //               {"channel", channel},
 //               {"user", user }
 //           };

 //           return await _client.PostJson<ChannelResponse>(endpoint, body);
 //       }

 //       public async Task<ChannelResponse> Leave(string channel)
 //       {
 //           const string endpoint = "channels.leave";

 //           var body = new Dictionary<string, object>
 //           {
 //               {"channel", channel}
 //           };

 //           return await _client.PostJson<ChannelResponse>(endpoint, body);
 //       }

 //       public async Task<ChannelsResponse> List(bool exclude_archived = true, bool exclude_members = true, int limit = 0)
 //       {
 //           const string endpoint = "channels.list";

 //           var body = new Dictionary<string, object>
 //           {
 //               {"exclude_archived", exclude_archived },
 //               {"exclude_members", exclude_members },
 //               {"limit", limit }
 //           };

 //           return await _client.PostJson<ChannelsResponse>(endpoint, body);
 //       }

 //       public async Task<ChannelResponse> Info(string channel)
 //       {
 //           const string endpoint = "channels.info";

 //           var body = new Dictionary<string, object>
 //           {
 //               {"channel", channel}
 //           };

 //           return await _client.PostJson<ChannelResponse>(endpoint, body);
 //       }

 //       public async Task<ChannelResponse> Invite(string channel, string user)
 //       {
 //           const string endpoint = "channels.invite";

 //           var body = new Dictionary<string, object>
 //           {
 //               {"channel", channel},
 //               {"user", user}
 //           };

 //           return await _client.PostJson<ChannelResponse>(endpoint, body);
 //       }

	//	public Task<ChannelResponse> Join(string token, string channelName, bool validate = false)
	//	{
	//		const string endpoint = "channels.join";

	//		var body = new Dictionary<string,object>
	//		{
	//			{ "token", token },
	//			{ "name", channelName },
	//			{ "validate", validate.ToString() }
	//		};

	//		return _client.PostJson<ChannelResponse>(endpoint, body);
	//	}
	//}
}