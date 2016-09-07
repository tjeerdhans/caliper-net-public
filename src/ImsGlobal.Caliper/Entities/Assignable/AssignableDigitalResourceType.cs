using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Assignable
{
    [JsonConverter(typeof(JsonValueConverter<AssignableDigitalResourceType>))]
    public sealed class AssignableDigitalResourceType : IType, IJsonValue
    {
        public static readonly AssignableDigitalResourceType Assessment = new AssignableDigitalResourceType("http://purl.imsglobal.org/caliper/v1/Assessment");
        public static readonly AssignableDigitalResourceType AssessmentItem = new AssignableDigitalResourceType("http://purl.imsglobal.org/caliper/v1/AssessmentItem");

        public AssignableDigitalResourceType()
        {
        }

        public AssignableDigitalResourceType(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }
}