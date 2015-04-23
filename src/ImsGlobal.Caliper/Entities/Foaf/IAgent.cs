using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Foaf {
	using ImsGlobal.Caliper.Entities.W3c;
	using ImsGlobal.Caliper.Util;

	/// <summary>
	/// An entity that can do things. Typical kinds of agents include people,
	/// organizations and software systems.
	/// See http://xmlns.com/foaf/spec/#term_Agent
	/// </summary>
	public interface IAgent : IJsonId {

		IType Type { get; set; }

		IList<IMembership> Memberships { get; }

	}

}
