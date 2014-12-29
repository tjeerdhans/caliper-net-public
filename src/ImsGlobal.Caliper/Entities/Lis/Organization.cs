using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Lis {

	public class Organization : Agent {

		public sealed class OrganizationType {

			public static readonly OrganizationType CourseSection = new OrganizationType( "http://purl.imsglobal.org/caliper/v1/lis/CourseSection" );

			private OrganizationType( string uri ) {
				this.Uri = uri;
			}

			public string Uri { get; private set; }
		}

		public Organization( string id )
			: this( id, null ) {
		}

		public Organization( string id, Organization parentOrg )
			: base( id ) {
			this.Type = AgentType.LisOrganization.Uri;
			this.ParentOrg = parentOrg;
		}

		[JsonProperty( "parentOrg", Order = 11 )]
		public Organization ParentOrg { get; set; }

		[JsonProperty( "title", Order = 12 )]
		public string Title { get; set; }

	}

}
