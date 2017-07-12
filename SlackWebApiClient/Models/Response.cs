using Newtonsoft.Json;
using SlackWebApiClient.Interfaces.Models;

namespace SlackWebApiClient.Models
{
    public class Response : IResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }
}