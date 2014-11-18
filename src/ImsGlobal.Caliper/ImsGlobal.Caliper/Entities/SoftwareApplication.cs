using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities {

	public class SoftwareApplication : Agent {

		public SoftwareApplication( string id )
			: base( id ) {
			this.Type = AgentType.SoftwareApplication.Uri;
		}
	}

}
