using System.Collections.Generic;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Response
{
    public class SelectTextResponse : Response
    {
        public SelectTextResponse(string id)
            : base(id)
        {
            Type = ResponseType.SelectText;
        }

        [JsonProperty("values", Order = 31)]
        public IList<string> Values { get; set; }
    }
}