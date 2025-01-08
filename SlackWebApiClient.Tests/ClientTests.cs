using System;
using System.IO;
using System.Threading.Tasks;
using SlackWebApiClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace SlackWebApiClient.Tests
{
    [TestClass]
    public class ClientTests
    {
        private readonly string _token;
        private readonly string _url = "https://slack.com/api";

        public ClientTests()
        {
            JObject o1 = JObject.Parse(File.ReadAllText("config.json"));
            _token = o1.GetValue("SlackApiToken").ToString();
        }

        [TestMethod]
        public void CreateClient_ReturnsClient()
        {
            var api = new SlackApi(_token);
            
            Assert.IsNotNull(api, "api != null");
            Assert.AreEqual(api.Token, _token);
            Assert.AreEqual(api.Url, _url);
        }

        // TODO: Update tests to use Conversations instead of Channels

        //[TestMethod]
        //public async Task GetChannelsList_ReturnsList()
        //{
        //    var api = new SlackApi(_token);

        //    var channels = await api.Channels.List();

        //    Assert.IsNotNull(channels);
        //    Assert.IsNotNull(channels.Channels);
        //    Assert.IsTrue(channels.Channels.Count > 0);
        //}

        //[TestMethod]
        //public async Task GetChannelsInfo_ReturnsInfo()
        //{
        //    var api = new SlackApi(_token);

        //    var channel = await api.Channels.Info("C03K226LE");

        //    Assert.IsNotNull(channel);
        //    Assert.IsNotNull(channel.Channel);

        //    Assert.AreEqual(channel.Channel.Name, "general", "channel name == general");
        //    Assert.IsTrue(channel.Channel.Members.Count > 0, "channel.Channel.Members.Count > 0");
        //}

        //[TestMethod]
        //public async Task GetGroupsInfo_ReturnsInfo()
        //{
        //    var api = new SlackApi(_token);

        //    var channel = await api.Groups.Info("G151SK5PB");

        //    Assert.IsNotNull(channel);
        //    Assert.IsNotNull(channel.Group);

        //    Assert.AreEqual(channel.Group.Name, "api_testing", "channel name == api_testing");
        //    Assert.IsTrue(channel.Group.Members.Count > 0, "channel.Channel.Members.Count > 0");
        //}
    }
}
