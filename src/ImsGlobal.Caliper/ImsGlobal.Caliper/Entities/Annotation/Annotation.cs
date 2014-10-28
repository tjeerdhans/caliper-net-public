using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ImsGlobal.Caliper.Entities.SchemaDotOrg;

namespace ImsGlobal.Caliper.Entities.Annotation {

	public class Annotation : CaliperEntity, IThing {

		public Annotation( string id ) {
			this.Id = id;
			this.Type = "http://purl.imsglobal.org/caliper/v1/Annotation";
		}

	}

}
