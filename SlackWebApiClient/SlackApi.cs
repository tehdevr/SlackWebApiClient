using SlackWebApiClient.Implementations;

namespace SlackWebApiClient
{
    public class SlackApi
    {
        public readonly string Token;
        public readonly string Url;
        public Channels Channels { get; set; }
        public Groups Groups { get; set; }
        public Im Im { get; set; }
        public Mpim Mpim { get; set; }
        public Users Users { get; set; }
        public Chat Chat { get; set; }

        public SlackApi(string token, string apiUrl = "https://slack.com/api")
        {
            Token = token;
            Url = apiUrl;

            var client = new Client(token, Url);

            Channels = new Channels(client);
            Groups = new Groups(client);
            Im = new Im(client);
            Mpim = new Mpim(client);
            Users = new Users(client);
            Chat = new Chat(client);
        }
    }
}