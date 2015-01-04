using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Assignable {
	using ImsGlobal.Caliper.Entities.Foaf;

	/// <summary>
	/// Representation of an Attempt. Attempts are generated as part of or
	/// are the object of an interaction represented by an AssignableEvent.
	/// </summary>
	public class Attempt : Entity {

		public Attempt( string id )
			: base( id ) {
			this.Type = EntityType.Attempt.Uri;
		}

		[JsonIgnore]
		public IAssignable Assignable { get; set; }

		[JsonIgnore]
		public IAgent Actor { get; set; }

		[JsonProperty( "count", Order = 11 )]
		public int Count { get; set; }

		[JsonProperty( "startedAtTime", Order = 12 )]
		public long StartedAtTime { get; set; }

		[JsonProperty( "endedAtTime", Order = 12 )]
		public long EndedAtTime { get; set; }

		/// <summary>
		/// An xsd:duration (http://books.xmlschemata.org/relaxng/ch19-77073.html)
		/// <remarks>The format is expected to be PnYnMnDTnHnMnS
		/// Valid values include PT1004199059S, PT130S, PT2M10S, P1DT2S, -P1Y, or P1Y2M3DT5H20M30.123S.
		/// The following values are invalid: 1Y (leading P is missing), P1S (T separator is missing), 
		/// P-1Y (all parts must be positive), P1M2Y (parts order is significant and Y must precede M), 
		/// or P1Y-1M (all parts must be positive).</remarks>
		/// </summary>
		[JsonProperty( "duration", Order = 13 )]
		public string Duration { get; set; }

	}

}
