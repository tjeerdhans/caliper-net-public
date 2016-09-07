using ImsGlobal.Caliper.Entities.W3c;
using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Lis
{
    [JsonConverter(typeof(JsonValueConverter<Status>))]
    public sealed class Status : IStatus, IType, IJsonValue
    {
        public static readonly Status Active = new Status("http://purl.imsglobal.org/vocab/lis/v2/status#Active");
        public static readonly Status Deleted = new Status("http://purl.imsglobal.org/vocab/lis/v2/status#Deleted");
        public static readonly Status Inactive = new Status("http://purl.imsglobal.org/vocab/lis/v2/status#Inactive");

        public Status()
        {
        }

        public Status(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }
}