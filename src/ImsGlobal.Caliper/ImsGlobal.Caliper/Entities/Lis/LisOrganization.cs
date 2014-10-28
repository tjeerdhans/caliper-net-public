using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Lis {

	public class LisOrganization : CaliperEntity, ICaliperAgent {

		private const string TYPE_URI = "http://purl.imsglobal.org/caliper/v1/LISOrganization";

		public LisOrganization()
			: base() {

			this.Type = TYPE_URI;
		}

		public LisOrganization( string id, LisOrganization parentOrg )
			: this() {
			this.Id = id;
			this.ParentOrg = parentOrg;
		}

		[JsonProperty( "parentOrg", Order = 11 )]
		public LisOrganization ParentOrg { get; set; }

		[JsonProperty( "title", Order = 12 )]
		public string Title { get; set; }

	}

}
