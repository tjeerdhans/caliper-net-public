using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using NodaTime;

namespace ImsGlobal.Caliper.Events {
	using ImsGlobal.Caliper.Entities.Foaf;

	/// <summary>
	/// Core base class for all Caliper events.
	/// </summary>
	public class BaseEvent {

		public BaseEvent() {
			this.Context = CaliperContext.Context;
			this.Type = EventType.Event;
		}
	
		/// <summary>
		/// Required - JSON-LD context for the CaliperEvent
		/// </summary>
		[JsonProperty( "@context", Order = 1 )]
		public CaliperContext Context { get; set; }

		/// <summary>
		/// Required - Type of the CaliperEvent
		/// </summary>
		[JsonProperty( "@type", Order = 2 )]
		public EventType Type { get; set; }

		/// <summary>
		/// Required - Agent (User, System) that performed the action
		/// </summary>
		[JsonProperty( "actor", Order = 3 )]
		public IAgent Actor { get; set; }

		/// <summary>
		/// Required - Action performed by the agent - from Metric Profile
		/// </summary>
		[JsonProperty( "action", Order = 4 )]
		public Action Action { get; set; }

		/// <summary>
		/// Required - "Activity Context" - from Metric Profile
		/// </summary>
		[JsonProperty( "object", Order = 5 )]
		public dynamic Object { get; set; }

		/// <summary>
		/// Required - time that the event was started at
		/// </summary>
		[JsonProperty( "eventTime", Order = 8 )]
		public Instant? EventTime { get; set; }

	}

}
