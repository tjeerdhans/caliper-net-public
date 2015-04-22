using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Agent {
	using ImsGlobal.Caliper.Entities.Foaf;
	using ImsGlobal.Caliper.Entities.SchemaDotOrg;
	using ImsGlobal.Caliper.Entities.W3c;

	public class SoftwareApplication : Entity, IAgent, ISoftwareApplication {

		public SoftwareApplication( string id )
			: base( id ) {
			this.Type = EntityType.SoftwareApplication;
			this.Memberships = new List<IMembership>();
		}

		[JsonProperty( "hasMembership", Order = 11 )]
		public IList<IMembership> Memberships { get; set; }

	}

}
