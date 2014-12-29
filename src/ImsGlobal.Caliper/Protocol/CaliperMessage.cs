using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Protocol {

	internal class CaliperMessage {

		[JsonProperty( "id", Order = 1 )]
		public string Id { get; set; }

		[JsonProperty( "type", Order = 2 )]
		public string Type { get; set; }

		[JsonProperty( "time", Order = 3 )]
		public string Time { get; set; }

		[JsonProperty( "data", Order = 4 )]
		public object Data { get; set; }

	}

}
