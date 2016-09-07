using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Response
{
    [JsonConverter(typeof(JsonValueConverter<ResponseType>))]
    public sealed class ResponseType : IType, IJsonValue
    {
        public static readonly ResponseType FillInBlank =
            new ResponseType("http://purl.imsglobal.org/caliper/v1/FillinBlankResponse");

        public static readonly ResponseType MultipleChoice =
            new ResponseType("http://purl.imsglobal.org/caliper/v1/MultipleChoiceResponse");

        public static readonly ResponseType MultipleResponse =
            new ResponseType("http://purl.imsglobal.org/caliper/v1/MultipleResponseResponse");

        public static readonly ResponseType SelectText =
            new ResponseType("http://purl.imsglobal.org/caliper/v1/SelectTextResponse");

        public static readonly ResponseType TrueFalse =
            new ResponseType("http://purl.imsglobal.org/caliper/v1/TrueFalseResponse");

        public ResponseType()
        {
        }

        public ResponseType(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }
}