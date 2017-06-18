using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackWebApiClient.Models
{
    public class Im : ChannelBase
    {
        [JsonProperty("is_im")]
        public string IsIm { get; set; }

        [JsonProperty("is_user_deleted")]
        public string IsUserDeleted { get; set; }
    }

    public class ImsResponse : Response
    {
        [JsonProperty("ims")]
        public IList<Im> Ims { get; set; }
    }
}