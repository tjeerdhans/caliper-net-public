using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Assessment {
	using ImsGlobal.Caliper.Entities.Assignable;
	using ImsGlobal.Caliper.Entities.Qti;

	public class Assessment : AssignableDigitalResource, IAssignable, IAssessment {

		public Assessment( string id )
			: base( id ) {
			this.Type = AssignableDigitalResourceType.Assessment;
		}

		/// <summary>
		/// List of assessment items that belong to this resource.
		/// </summary>
		[JsonProperty( "assessmentItems", Order = 31 )]
		public IList<AssessmentItem> AssessmentItems { get; set; }

	}

}
