using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Agent {
	using ImsGlobal.Caliper.Entities.Foaf;

	public class Agent : BaseEntity, IAgent {

		public Agent( string id )
			: base( id ) {
		}

	}

}
