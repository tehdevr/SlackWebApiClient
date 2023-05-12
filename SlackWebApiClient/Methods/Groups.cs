using System.Collections.Generic;
using System.Threading.Tasks;
using SlackWebApiClient.Interfaces.Methods;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Methods
{
    //public class Groups : IGroups
    //{
    //    private readonly Client _client;

    //    public Groups(Client client)
    //    {
    //        _client = client;
    //    }

    //    public async Task<GroupsResponse> List(bool excludeArchive = true, bool excludeMembers = false)
    //    {
    //        var endpoint = $"groups.list";

    //        return await _client.PostJson<GroupsResponse>(endpoint);
    //    }

    //    public async Task<GroupResponse> Info(string group)
    //    {
    //        var url = $"groups.info";

    //        var body = new Dictionary<string, object>
    //        {
    //            {"channel", group}
    //        };

    //        return await _client.PostJson<GroupResponse>(url, body);
    //    }

    //    public async Task<MessagesResponse> Messages(
    //        string channel,
    //        string ts = null,
    //        string latest = null,
    //        string oldest = null,
    //        int? count = null,
    //        bool inclusive = false,
    //        bool unreads = false)
    //    {
    //        var endpoint = $"groups.history";

    //        return await _client.GetMessages<MessagesResponse>(endpoint, channel, ts, latest, oldest, count, inclusive,
    //            unreads);
    //    }

    //    public async Task<GroupResponse> Invite(string channel, string user)
    //    {
    //        var endpoint = $"groups.invite";

    //        var body = new Dictionary<string, object>
    //        {
    //            {"channel", channel},
    //            {"user", user }
    //        };

    //        return await _client.PostJson<GroupResponse>(endpoint, body);
    //    }

    //    public async Task<Response> Kick(string channel, string user)
    //    {
    //        var endpoint = $"groups.kick";

    //        var body = new Dictionary<string, object>
    //        {
    //            {"channel", channel},
    //            {"user", user }
    //        };

    //        return await _client.PostJson<GroupResponse>(endpoint, body);
    //    }
    //}
}