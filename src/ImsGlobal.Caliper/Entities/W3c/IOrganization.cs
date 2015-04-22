using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.W3c {

	/// <summary>
	/// A collection of people organized together into a community or other
	/// social, commercial or political structure. The group has some common
	/// purpose or reason for existence which goes beyond the set of people
	/// belonging to it and can act as an Agent. Organizations are often
	/// decomposable into hierarchical structures.
	/// </summary>
	public interface IOrganization {

		/// <summary>
		/// An identifier that can be used to used to uniquely identify the
		/// organization.  Equivalent to org:identifier.
		/// </summary>
		string Id { get; }

		/// <summary>
		/// A membership entity that records the role of some Agent within this Organization.
		/// </summary>
		IList<IMembership> Membership { get; }

		/// <summary>
		/// Equivalent of W3C Organization Ontology org:subOrganizationOf
		/// property. Represents hierarchical containment of Organizations
		/// or OrganizationalUnits; indicates an Organization which
		/// contains this Organization.
		/// </summary>
		IOrganization SubOrganizationOf { get; }

	}

}
