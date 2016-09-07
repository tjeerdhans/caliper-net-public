using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper
{
    [JsonConverter(typeof(JsonValueConverter<CaliperContext>))]
    public sealed class CaliperContext : IJsonValue
    {
        public static readonly CaliperContext Context = new CaliperContext("http://purl.imsglobal.org/ctx/caliper/v1/Context");

        public CaliperContext()
        {
        }

        public CaliperContext(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }
}