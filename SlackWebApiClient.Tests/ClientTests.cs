using System;
using System.Threading.Tasks;
using SlackWebApiClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SlackWebApiClient.Tests
{
    [TestClass]
    public class ClientTests
    {
        private const string Token = "";
        private const string Url = "https://slack.com/api";

        [TestMethod]
        public void CreateClient_ReturnsClient()
        {
            var api = new SlackApi(Token);
            
            Assert.IsNotNull(api, "api != null");
            Assert.AreEqual(api.Token, Token);
            Assert.AreEqual(api.Url, Url);
        }

        [TestMethod]
        public async Task GetChannelsList_ReturnsList()
        {
            var api = new SlackApi(Token);

            var channels = await api.Channels.List();

            Assert.IsNotNull(channels);
            Assert.IsNotNull(channels.Channels);
            Assert.IsTrue(channels.Channels.Count > 0);
        }

        [TestMethod]
        public async Task GetChannelsInfo_ReturnsInfo()
        {
            var api = new SlackApi(Token);

            var channel = await api.Channels.Info("C03K226LE");

            Assert.IsNotNull(channel);
            Assert.IsNotNull(channel.Channel);

            Assert.AreEqual(channel.Channel.Name, "general", "channel name == general");
            Assert.IsTrue(channel.Channel.Members.Count > 0, "channel.Channel.Members.Count > 0");
        }

        [TestMethod]
        public async Task GetGroupsInfo_ReturnsInfo()
        {
            var api = new SlackApi(Token);

            var channel = await api.Groups.Info("G151SK5PB");

            Assert.IsNotNull(channel);
            Assert.IsNotNull(channel.Group);

            Assert.AreEqual(channel.Group.Name, "api_testing", "channel name == api_testing");
            Assert.IsTrue(channel.Group.Members.Count > 0, "channel.Channel.Members.Count > 0");
        }
    }
}
