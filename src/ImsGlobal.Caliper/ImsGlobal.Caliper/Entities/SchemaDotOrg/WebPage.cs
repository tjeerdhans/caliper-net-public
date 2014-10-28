using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.SchemaDotOrg {

	public class WebPage : CaliperDigitalResource, ICreativeWork {

		public WebPage( string id ) {
			this.Id = id;
			this.Type = "http://purl.imsglobal.org/caliper/v1/WebPage";
		}

	}

}
