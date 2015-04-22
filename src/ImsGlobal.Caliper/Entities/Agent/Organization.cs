using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Agent {
	using ImsGlobal.Caliper.Entities.W3c;

	/// <summary>
	/// A collection of people organized together into a community or other
	/// social, commercial or political structure. The group has some common
	/// purpose or reason for existence which goes beyond the set of people
	/// belonging to it and can act as an Agent. Organizations are often
	/// decomposable into hierarchical structures.
	/// </summary>
	public class Organization : Entity, IOrganization {

		public Organization( string id )
			: base( id ) {
			this.Type = EntityType.Organization.Uri;
			this.Membership = new List<IMembership>();
		}

		[JsonProperty( "membership", Order = 11 )]
		public IList<IMembership> Membership { get; set; }

		[JsonProperty( "subOrganizationOf", Order = 12 )]
		public IOrganization SubOrganizationOf { get; set; }

	}

}
