using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Events {
	using ImsGlobal.Caliper.Entities;
	using ImsGlobal.Caliper.Entities.Foaf;
	using ImsGlobal.Caliper.Entities.Lis;

	/// <summary>
	/// Base class for all Caliper events.
	/// </summary>
	public abstract class Event {

		public sealed class EventContext {

			public static readonly EventContext Annotation = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/AnnotationEvent" );
			public static readonly EventContext Assessment = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/AssessmentEvent" );
			public static readonly EventContext AssessmentItem = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/AssessmentItemEvent" );
			public static readonly EventContext Assignable = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/AssignableEvent" );
			public static readonly EventContext Event = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/Event" );
			public static readonly EventContext Media = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/MediaEvent" );
			public static readonly EventContext Navigation = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/NavigationEvent" );
			public static readonly EventContext Outcome = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/OutcomeEvent" );
			public static readonly EventContext View = new EventContext( "http://purl.imsglobal.org/ctx/caliper/v1/ViewEvent" );

			private EventContext( string uri ) {
				this.Uri = uri;
			}

			public string Uri { get; private set; }
		}

		public sealed class EventType {

			public static readonly EventType Annotation = new EventType( "http://purl.imsglobal.org/caliper/v1/AnnotationEvent" );
			public static readonly EventType Assessment = new EventType( "http://purl.imsglobal.org/caliper/v1/AssessmentEvent" );
			public static readonly EventType AssessmentItem = new EventType( "http://purl.imsglobal.org/caliper/v1/AssessmentItemEvent" );
			public static readonly EventType Assignable = new EventType( "http://purl.imsglobal.org/caliper/v1/AssignableEvent" );
			public static readonly EventType Event = new EventType( "http://purl.imsglobal.org/caliper/v1/Event" );
			public static readonly EventType Media = new EventType( "http://purl.imsglobal.org/caliper/v1/MediaEvent" );
			public static readonly EventType Navigation = new EventType( "http://purl.imsglobal.org/caliper/v1/NavigationEvent" );
			public static readonly EventType Outcome = new EventType( "http://purl.imsglobal.org/caliper/v1/OutcomeEvent" );
			public static readonly EventType View = new EventType( "http://purl.imsglobal.org/caliper/v1/ViewEvent" );

			private EventType( string uri ) {
				this.Uri = uri;
			}

			public string Uri { get; private set; }
		}

		// ------ Core Properties ------

		/// <summary>
		/// Required - JSON-LD context for the CaliperEvent
		/// </summary>
		[JsonProperty( "@context", Order = 1 )]
		public string Context { get; set; }

		/// <summary>
		/// Required - Type of the CaliperEvent
		/// </summary>
		[JsonProperty( "@type", Order = 2 )]
		public string Type { get; set; }

		/// <summary>
		/// Required - Agent (User, System) that performed the action
		/// </summary>
		[JsonProperty( "actor", Order = 3 )]
		public IAgent Actor { get; set; }

		/// <summary>
		/// Required - Action performed by the agent - from Metric Profile
		/// </summary>
		[JsonProperty( "action", Order = 4 )]
		public string Action { get; protected set; }

		/// <summary>
		/// Required - "Activity Context" - from Metric Profile
		/// </summary>
		[JsonProperty( "object", Order = 5 )]
		public dynamic Object { get; set; }

		/// <summary>
		/// Optional - "target" - from Metric Profile
		/// </summary>
		[JsonProperty( "target", Order = 6 )]
		public dynamic Target { get; set; }

		/// <summary>
		/// Optional - entity "generated" as result of action - from Metric Profile
		/// </summary>
		[JsonProperty( "generated", Order = 7 )]
		public dynamic Generated { get; set; }

		/// <summary>
		/// Required - time in milliseconds that the event was started at
		/// </summary>
		[JsonProperty( "startedAtTime", Order = 8 )]
		public long StartedAt { get; set; }

		/// <summary>
		/// An optional time in milliseconds that the event ended at
		/// </summary>
		[JsonProperty( "endedAtTime", Order = 9 )]
		public long EndedAt { get; set; }

		/// <summary>
		/// An xsd:duration (http://books.xmlschemata.org/relaxng/ch19-77073.html)
		/// <remarks>The format is expected to be PnYnMnDTnHnMnS
		/// Valid values include PT1004199059S, PT130S, PT2M10S, P1DT2S, -P1Y, or P1Y2M3DT5H20M30.123S.
		/// The following values are invalid: 1Y (leading P is missing), P1S (T separator is missing), 
		/// P-1Y (all parts must be positive), P1M2Y (parts order is significant and Y must precede M), 
		/// or P1Y-1M (all parts must be positive).</remarks>
		/// </summary>
		[JsonProperty( "duration", Order = 10 )]
		public string Duration { get; set; }

		// ------ Contextual Properties ------

		/// <summary>
		/// EdApp context
		/// </summary>
		[JsonProperty( "edApp", Order = 11 )]
		public SoftwareApplication EdApp { get; set; }

		/// <summary>
		/// Group context
		/// </summary>
		[JsonProperty( "group", Order = 12 )]
		public Organization LisOrg { get; set; }

	}

}
