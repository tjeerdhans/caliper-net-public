using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Response {
	using ImsGlobal.Caliper.Util;

	[JsonConverter( typeof( JsonValueConverter<ResponseType> ) )]
	public sealed class ResponseType : IType, IJsonValue {

		public static readonly ResponseType FillInBlank = new ResponseType( "http://purl.imsglobal.org/caliper/v1/Response/FillinBlank" );
		public static readonly ResponseType MultipleChoice = new ResponseType( "http://purl.imsglobal.org/caliper/v1/Response/MultipleChoice" );
		public static readonly ResponseType MultipleResponse = new ResponseType( "http://purl.imsglobal.org/caliper/v1/Response/MultipleResponse" );
		public static readonly ResponseType SelectText = new ResponseType( "http://purl.imsglobal.org/caliper/v1/Response/SelectText" );
		public static readonly ResponseType TrueFalse = new ResponseType( "http://purl.imsglobal.org/caliper/v1/Response/TrueFalse" );

		public ResponseType() {}

		public ResponseType( string value ) {
			this.Value = value;
		}

		public string Value { get; set; }
	}
}