using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Assignable {

	public class AssignableDigitalResource : DigitalResource, IAssignable {

		public sealed class AssignableDigitalResourceType {

			public static readonly AssignableDigitalResourceType Assessment = new AssignableDigitalResourceType( "http://purl.imsglobal.org/caliper/v1/Assessment" );
			public static readonly AssignableDigitalResourceType AssessmentItem = new AssignableDigitalResourceType( "http://purl.imsglobal.org/caliper/v1/AssessmentItem" );

			private AssignableDigitalResourceType( string uri ) {
				this.Uri = uri;
			}

			public string Uri { get; private set; }
		}

		public AssignableDigitalResource( string id )
			: base( id ) {
			this.Type = DigitalResourceType.AssignableDigitalResource.Uri;
		}

		[JsonProperty( "dateCreated", Order = 21 )]
		public long DateCreated { get; set; }

		[JsonProperty( "datePublished", Order = 22 )]
		public long DatePublished { get; set; }

		[JsonProperty( "dateToStartOn", Order = 23 )]
		public long DateToStartOn { get; set; }

		[JsonProperty( "dateToActivate", Order = 24 )]
		public long DateToActivate { get; set; }

		[JsonProperty( "dateToShow", Order = 25 )]
		public long DateToShow { get; set; }

		[JsonProperty( "dateToSubmit", Order = 26 )]
		public long DateToSubmit { get; set; }

		[JsonProperty( "maxAttempts", Order = 27 )]
		public int MaxAttempts { get; set; }

		[JsonProperty( "maxSubmits", Order = 28 )]
		public int MaxSubmits { get; set; }

		[JsonProperty( "maxScore", Order = 29 )]
		public double MaxScore { get; set; }

	}

}
