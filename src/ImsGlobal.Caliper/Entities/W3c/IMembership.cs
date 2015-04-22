using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.W3c {

	/// <summary>
	/// Indicates the nature of an Agent's membership in an organization.
	/// A W3C Membership represents an n-ary relationship between an
	/// Agent, an Organization and a Role. A Caliper Membership varies
	/// from the W3C Membership class definition by allowing users to
	/// specify a set of roles associated with an Agent's membership in
	/// an organization.
	/// See http://www.w3.org/TR/vocab-org/#org:Membership
	/// </summary>
	public interface IMembership {

		/// <summary>
		/// The Person (or other Agent including Organization) involved
		/// in the Membership relationship.
		/// </summary>
		string MemberId { get; }

		/// <summary>
		/// The Organization in which the Agent is a member.
		/// </summary>
		string OrganizationId { get; }

		/// <summary>
		/// The set of roles that the agent plays in a membership
		/// relationship with an organization. Each string is expected
		/// to be in the form of a dereferenceable URI.
		/// </summary>
		IList<IRole> Roles { get; }

		/// <summary>
		/// The current status of a membership which applies to all roles.
		/// </summary>
		IStatus Status { get; }
	}

}
