using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Agent {
	using ImsGlobal.Caliper.Entities.SchemaDotOrg;

	public class SoftwareApplication : Agent, ISoftwareApplication {

		public SoftwareApplication( string id )
			: base( id ) {
			this.Type = EntityType.SoftwareApplication;
		}

	}

}
