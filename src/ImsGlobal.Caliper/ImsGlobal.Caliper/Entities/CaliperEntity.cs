using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities {

	public class CaliperEntity {

		[JsonProperty( "@id", Order = 1 )]
		public string Id { get; set; }

		[JsonProperty( "@type", Order = 2 )]
		public string Type { get; set; }

		[JsonProperty( "lastModifiedTime", Order = 3 )]
		public long LastModifiedAt { get; set; }

		[JsonIgnore]
		[JsonProperty( "properties", Order = 4 )]
		public dynamic Properties { get; set; }

	}

}
