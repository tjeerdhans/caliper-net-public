using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Lis {

	public class CourseSection : Organization {

		public CourseSection( string id )
			: this( id, null ) {
		}

		public CourseSection( string id, Organization parentOrg )
			: base( id, parentOrg ) {
			this.Type = OrganizationType.CourseSection.Uri;
		}

		[JsonProperty( "label", Order = 21 )]
		public string Label { get; set; }

		[JsonProperty( "courseNumber", Order = 22 )]
		public string CourseNumber { get; set; }

		[JsonProperty( "semester", Order = 23 )]
		public string Semester { get; set; }

	}

}
