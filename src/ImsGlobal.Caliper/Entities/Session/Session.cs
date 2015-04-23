using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using NodaTime;

namespace ImsGlobal.Caliper.Entities.Session {
	using ImsGlobal.Caliper.Entities.Foaf;
	using ImsGlobal.Caliper.Util;

	public class Session : Entity {

		public Session( string id )
			: base( id ) {
			this.Type = EntityType.Session;
		}

		[JsonProperty( "actor", Order = 11 )]
		public IAgent Actor { get; set; }

		[JsonProperty( "startedAtTime", Order = 12 )]
		public Instant? StartedAt { get; set; }

		[JsonProperty( "endedAtTime", Order = 13 )]
		public Instant? EndedAt { get; set; }

		[JsonProperty( "duration", Order = 14 )]
		public Period Duration { get; set; }

	}

}
