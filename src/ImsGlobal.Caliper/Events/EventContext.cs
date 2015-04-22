using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Events {
	using ImsGlobal.Caliper.Util;

	[JsonConverter( typeof( JsonValueConverter<EventContext> ) )]
	public sealed class EventContext : IJsonValue {

		public static readonly EventContext Annotation = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/AnnotationEvent" );
		public static readonly EventContext Assessment = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/AssessmentEvent" );
		public static readonly EventContext AssessmentItem = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/AssessmentItemEvent" );
		public static readonly EventContext Assignable = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/AssignableEvent" );
		public static readonly EventContext Event = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/Event" );
		public static readonly EventContext Media = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/MediaEvent" );
		public static readonly EventContext Navigation = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/NavigationEvent" );
		public static readonly EventContext Outcome = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/OutcomeEvent" );
		public static readonly EventContext Session = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/SessionEvent" );
		public static readonly EventContext View = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/ViewEvent" );

		public EventContext() {}

		public EventContext( string value ) {
			this.Value = value;
		}

		public string Value { get; set; }
	}

}