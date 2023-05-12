using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SlackWebApiClient.Interfaces.Methods;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Methods
{
    public class Views : IViews
    {
        private readonly Client _client;

        public Views(Client client)
        {
            _client = client;
        }

        public async Task<ViewsOpenResponse> Open(
            string triggerID,
            ModalView modalView)
        {
            var url = $"views.open";

            var body = new Dictionary<string, object>
            {
                {"trigger_id", triggerID},
                {"view", modalView}
            };

            //string json = SlackUtils.SerializeHard(body);

            // TODO: test this, then actually do the call
            return await _client.PostJson<ViewsOpenResponse>(url, body);
            //Dictionary<string, List<string>> metadata = new Dictionary<string, List<string>>();
            //metadata.Add("json", new List<string>(new string[] { json }));
            //return new ModalViewResponse() { Ok = true, ResponseMetadata = metadata };
        }


    }


}