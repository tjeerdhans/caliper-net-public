using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using NodaTime;

namespace ImsGlobal.Caliper.Protocol {

	internal class CaliperMessage<T> {

		[JsonProperty( "@context", Order = 1 )]
		public string Context {
			get { return CaliperContext.Context.Value; }
		}

		[JsonProperty( "sensor", Order = 2 )]
		public string SensorId { get; set; }

		[JsonProperty( "sendTime", Order = 3 )]
		public Instant? SendTime { get; set; }

		[JsonProperty( "data", Order = 4 )]
		public IEnumerable<T> Data { get; set; }

	}

}
