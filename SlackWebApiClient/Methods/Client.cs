using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SlackWebApiClient.Interfaces.Methods;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Methods
{
    public class Client : IClient
    {
        private readonly string _apiUrl;
        private readonly string _token;

        public Client(string token, string apiUrl = "https://slack.com/api")
        {
            _token = token;
            _apiUrl = apiUrl;
        }

        public async Task<T> GetMessages<T>(
            string endpoint,
            string channel,
            string ts = null,
            string latest = null,
            string oldest = null,
            int? count = null,
            bool inclusive = false,
            bool unreads = false) where T : Response
        {
            var body = new Dictionary<string, string>
            {
                {"channel", channel}
            };

            if (ts != null) body.Add("ts", ts);
            if (latest != null) body.Add("latest", latest);
            if (oldest != null) body.Add("oldest", oldest);
            if (count != null) body.Add("count", count.ToString());
            if (inclusive) body.Add("inclusive", inclusive.ToString());
            if (unreads) body.Add("unreads", unreads.ToString());

            return await Post<T>(endpoint, body);
        }

        public async Task<T> Post<T>(string endpoint, Dictionary<string, string> content = null) where T : Response
        {
            var url = $"{_apiUrl}/{endpoint}";

            if (content != null) content.Add("token", _token);
            else content = new Dictionary<string, string> {{"token", _token}};

            T result;
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, new FormUrlEncodedContent(content));

                result = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }

            if(result.Error != null) throw new Exception(result.Error);

            return result;
        }
    }
}