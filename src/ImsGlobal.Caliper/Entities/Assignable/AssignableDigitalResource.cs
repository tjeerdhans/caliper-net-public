using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Assignable {

	public class AssignableDigitalResource : DigitalResource, IAssignable {

		public AssignableDigitalResource( string id )
			: base( id ) {
			this.Type = DigitalResourceType.AssignableDigitalResource;
		}

		[JsonProperty( "dateToActivate", Order = 24 )]
		public DateTime? DateToActivate { get; set; }

		[JsonProperty( "dateToShow", Order = 25 )]
		public DateTime? DateToShow { get; set; }

		[JsonProperty( "dateToStartOn", Order = 23 )]
		public DateTime? DateToStartOn { get; set; }

		[JsonProperty( "dateToSubmit", Order = 26 )]
		public DateTime? DateToSubmit { get; set; }

		[JsonProperty( "maxAttempts", Order = 27 )]
		public int MaxAttempts { get; set; }

		[JsonProperty( "maxSubmits", Order = 28 )]
		public int MaxSubmits { get; set; }

		[JsonProperty( "maxScore", Order = 29 )]
		public double MaxScore { get; set; }

	}

}
