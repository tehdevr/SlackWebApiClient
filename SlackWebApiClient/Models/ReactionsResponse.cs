using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackWebApiClient.Models
{
    public class ReactionsResponse : Response
    {
        public IList<Message> Items { get; set; }
    }
}
