using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities {
	using ImsGlobal.Caliper.Entities.Lis;

	/// <summary>
	/// Represents the learning context within which an activity is taking place.
	/// </summary>
	public class LearningContext {

		[JsonProperty( "edApp", Order = 1 )]
		public SoftwareApplication EdApp { get; set; }

		[JsonProperty( "lisOrganization", Order = 2 )]
		public Organization LisOrganization { get; set; }

		[JsonProperty( "agent", Order = 3 )]
		public Agent Agent { get; set; }
	
	}

}
