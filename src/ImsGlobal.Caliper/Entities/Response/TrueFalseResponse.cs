using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Response
{
    public class TrueFalseResponse : Response
    {
        public TrueFalseResponse(string id)
            : base(id)
        {
            Type = ResponseType.TrueFalse;
        }

        [JsonProperty("value", Order = 31)]
        public string Value { get; set; }
    }
}