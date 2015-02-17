using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using ImsGlobal.Caliper.Entities.Foaf;

namespace ImsGlobal.Caliper.Entities.Session {

	public class Session : Entity {

		public Session( string id )
			: base( id ) {
			this.Type = EntityType.Session.Uri;
		}

		[JsonProperty( "actor", Order = 11 )]
		public IAgent Actor { get; set; }

		[JsonProperty( "startedAtTime", Order = 12 )]
		public long StartedAt { get; set; }

		[JsonProperty( "endedAtTime", Order = 13 )]
		public long EndedAt { get; set; }

		[JsonProperty( "duration", Order = 14 )]
		public string Duration { get; set; }

	}

}
