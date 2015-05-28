using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Agent {
	using ImsGlobal.Caliper.Entities.Foaf;
	using ImsGlobal.Caliper.Entities.W3c;

	public abstract class Agent : Entity, IAgent {

		protected Agent( string id )
			: base( id ) {
			this.Type = EntityType.Agent;
			this.Roles = new List<IRole>();
		}

		[JsonProperty( "roles", Order = 11 )]
		public IList<IRole> Roles { get; set; }

	}

}
