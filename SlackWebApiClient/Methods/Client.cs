using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using SlackWebApiClient.Interfaces.Methods;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Methods
{
    public class Client : IClient
    {
        private readonly string _apiUrl;
        private readonly string _token;
        private static readonly HttpClient _httpClient = new HttpClient();

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
            var body = new Dictionary<string, object>
            {
                {"channel", channel}
            };

            if (ts != null) body.Add("ts", ts);
            if (latest != null) body.Add("latest", latest);
            if (oldest != null) body.Add("oldest", oldest);
            if (count != null) body.Add("count", count.ToString());
            if (inclusive) body.Add("inclusive", inclusive.ToString());
            if (unreads) body.Add("unreads", unreads.ToString());

            return await PostJson<T>(endpoint, body);
        }

        public async Task<T> PostJson<T>(string endpoint, Dictionary<string, object> content = null, bool suppressBearer = false) where T : Response
        {
            var url = $"{_apiUrl}/{endpoint}";

            T result;
            string jsonBody = string.Empty;
            string responseData = string.Empty;

            try
            {
                jsonBody = JsonConvert.SerializeObject(content, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });


                if (!suppressBearer)
                {
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                }
                else
                {
                    _httpClient.DefaultRequestHeaders.Authorization = null;
                }

                StringContent jsonContent = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _httpClient.PostAsync(url, jsonContent).Result;
                responseData = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<T>(responseData);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error sending message to Slack. Input:{jsonBody}  Output={responseData}", ex);
            }

            return result;
        }


        public async Task<T> PostForm<T>(string endpoint, List<KeyValuePair<string, string>> content = null, bool suppressBearer = false) where T : Response
        {
            var url = $"{_apiUrl}/{endpoint}";

            T result;
            string responseData = string.Empty;

            try
            {
                if (content != null)
                {
                    if (content.FindAll(p => p.Key == "token").Count == 0)
                    {
                        content.Add(new KeyValuePair<string, string>("token", _token));
                    }
                }
                else
                {
                    content = new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("token", _token) };
                }

                var response = _httpClient.PostAsync(url, new FormUrlEncodedContent(content)).Result;
                result = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error sending message to Slack. URL:{url}  Content={JsonConvert.SerializeObject(content)}  Output={responseData}", ex);
            }

            return result;
        }

        public async Task<OAuthAccessResponse> PostOauthAccess(string clientID, string clientSecret, string code, string redirect_uri = "", bool single_channel = false)
        {
            string endpoint = "oauth.access";
            string url = $"{_apiUrl}/{endpoint}";

            Dictionary<string, string> parms = new Dictionary<string, string>()
                {
                    { "code", code }
                };

            if (!string.IsNullOrWhiteSpace(redirect_uri))
            {
                parms.Add("redirect_uri", redirect_uri);
            }

            if (single_channel)
            {
                parms.Add("single_channel", "true");
            }


            var req = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new FormUrlEncodedContent(parms)
            };
            string basicCreds = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{clientID}:{clientSecret}"));
            req.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", basicCreds);
            var clientResponse = await _httpClient.SendAsync(req).ConfigureAwait(false);
            var responseBody = await clientResponse.Content.ReadAsStringAsync().ConfigureAwait(false);

            OAuthAccessResponse oaRsp = JsonConvert.DeserializeObject<OAuthAccessResponse>(responseBody);

            return oaRsp;
        }


        public async Task<T> Get<T>(string endpoint, IEnumerable<KeyValuePair<string, string>> parms)
        {
            var url = $"{_apiUrl}/{endpoint}";

            T result;

            StringBuilder query = new StringBuilder();
            string pre = "?";
            foreach (var item in parms)
            {
                query.Append($"{pre}{item.Key}={HttpUtility.UrlEncode(item.Value)}");
                pre = "&";
            }

            var clientResponse = await _httpClient.GetStringAsync($"{url}{query}").ConfigureAwait(false);
            result = JsonConvert.DeserializeObject<T>(clientResponse);
            return result;
        }

    }
}