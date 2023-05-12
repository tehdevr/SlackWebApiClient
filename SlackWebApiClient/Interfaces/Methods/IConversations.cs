using System.Threading.Tasks;
using SlackWebApiClient.Interfaces.Models;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Interfaces.Methods
{
	public interface IConversations
	{
		//Task<ChannelResponse> Archive	  (string channel);
		//Task<ChannelResponse> Close	  (string channel);
		//Task<ChannelResponse> Create	  (string name, bool is_private);
		//Task<ChannelResponse> History	  (string channel, string cursor, bool inclusive, string latest, int limit, string oldest);
		//Task<ChannelResponse> Info		  (string channel, bool include_locale, bool include_num_members);
		//Task<ChannelResponse> Invite	  (string channel, string users); // users = comma-separated list of user IDs, up to 1000 IDs.
		Task<ChannelResponse> Join		  (string channelID); 
		//Task<ChannelResponse> Kick		  (string channel, string user);
		//Task<ChannelResponse> Leave	  (string channel);
		//Task<ChannelsResponse> List	  (string cursor, bool exclude_archived, int limit, string types); // types = comma-separated combo of public_channel, private_channel, mpim, or im, defaults to public_channel
		//Task<ChannelResponse> Mark		  (string channel, string ts);
		//Task<ChannelResponse> Members	  (string channel, string cursor, int limit);
		//Task<ChannelResponse> Open		  (string channel, bool return_im, string users); // use channel OR users.  Users is comma-separated
		//Task<ChannelResponse> Rename	  (string channel, string name);
		//Task<ChannelResponse> Replies	  (string channel);
		//Task<ChannelResponse> SetPurpose (string channel);
		//Task<ChannelResponse> SetTopic	  (string channel);
		//Task<ChannelResponse> Unarchive  (string channel);
		//Task<ChannelsResponse> UsersConversations (string cursor = null, bool exclude_archived = false, int limit = 100, string types = null, string userID = null); // use POST form-urlencoded, not JSON


	}
}