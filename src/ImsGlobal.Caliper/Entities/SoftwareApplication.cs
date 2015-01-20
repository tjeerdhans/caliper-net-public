using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities {
	using ImsGlobal.Caliper.Entities.Foaf;
	using ImsGlobal.Caliper.Entities.SchemaDotOrg;

	public class SoftwareApplication : Entity, IAgent, ISoftwareApplication {

		public SoftwareApplication( string id )
			: base( id ) {
			this.Type = Agent.AgentType.SoftwareApplication.Uri;
		}
	}

}
