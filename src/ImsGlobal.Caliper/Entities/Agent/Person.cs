using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Agent {
	using ImsGlobal.Caliper.Entities.Foaf;

	public class Person : Entity, IAgent {

		public Person( string id )
			: base( id ) {
			this.Type = EntityType.Person;
		}

	}

}
