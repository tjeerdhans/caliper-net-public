using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Lis {

	public class Person : Agent {

		public Person( string id )
			: base( id ) {
			this.Type = AgentType.LisPerson.Uri;
		}

	}

}
