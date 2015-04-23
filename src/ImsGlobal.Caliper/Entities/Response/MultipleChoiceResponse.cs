using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Response {

	public class MultipleChoiceResponse : Response {

		public MultipleChoiceResponse( string id )
			: base( id ) {
			this.Type = ResponseType.MultipleChoice;
		}

		[JsonProperty( "value", Order = 31 )]
		public string Value { get; set; }

	}

}
