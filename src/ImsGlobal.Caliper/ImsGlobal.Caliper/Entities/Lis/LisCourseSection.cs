using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Lis {

	public class LisCourseSection : LisOrganization, ICaliperAgent {

		private const string TYPE_URI = "http://purl.imsglobal.org/caliper/v1/LISCourseSection";

		public LisCourseSection()
			: base() {

			this.Type = TYPE_URI;
		}

		public LisCourseSection( string id, LisOrganization parentOrg )
			: base(id, parentOrg) {

			this.Type = TYPE_URI;
		}

		[JsonProperty( "label", Order = 21 )]
		public string Label { get; set; }

		[JsonProperty( "courseNumber", Order = 22 )]
		public string CourseNumber { get; set; }

		[JsonProperty( "semester", Order = 23 )]
		public string Semester { get; set; }

	}

}
