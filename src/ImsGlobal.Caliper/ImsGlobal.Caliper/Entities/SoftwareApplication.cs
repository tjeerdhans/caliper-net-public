using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities {
	using ImsGlobal.Caliper.Entities.SchemaDotOrg;

	public class SoftwareApplication
		: CaliperEntity, ICaliperAgent, ICreativeWork {

		private const string TYPE_URI = "http://purl.imsglobal.org/caliper/v1/SoftwareApplication";
		
		public SoftwareApplication(string id) {
			this.Id = id;
			this.Type = TYPE_URI;
		}
	}

}
