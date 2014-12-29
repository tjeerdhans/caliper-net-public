using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Reading {

	public class Reading : DigitalResource {

		public Reading( string id )
			: base( id ) {
			this.Type = DigitalResourceType.Reading.Uri;
		}

		[JsonProperty( "learningResourceType", Order = 21 )]
		public string LearningResourceType { get; set; }

		[JsonProperty( "educationalUse", Order = 22 )]
		public string EducationalUse { get; set; }

		[JsonProperty( "timeRequired", Order = 23 )]
		public string TimeRequired { get; set; }

		[JsonProperty( "version", Order = 24 )]
		public string Version { get; set; }
	
	}

}
