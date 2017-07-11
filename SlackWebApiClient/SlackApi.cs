using SlackWebApiClient.Implementations;

namespace SlackWebApiClient
{
    public class SlackApi
    {
        public SlackApi(string token, string apiUrl = "https://slack.com/api")
        {
            var client = new Client(token, apiUrl);

            Channels = new Channels(client);
            Groups = new Groups(client);
            Im = new Im(client);
            Mpim = new Mpim(client);
            Users = new Users(client);
            Chat = new Chat(client);
        }

        public Channels Channels { get; set; }
        public Groups Groups { get; set; }
        public Im Im { get; set; }
        public Mpim Mpim { get; set; }
        public Users Users { get; set; }
        public Chat Chat { get; set; }
    }
}