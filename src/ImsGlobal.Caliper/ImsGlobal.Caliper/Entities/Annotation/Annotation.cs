using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Annotation {
	using ImsGlobal.Caliper.Entities.SchemaDotOrg;

	/// <summary>
	/// Base type for all annotation types. Direct sub-types, such as
	/// Highlight, Attachment, etc, are specified in the Caliper
	/// Annotation Metric Profile.
	/// </summary>
	public class Annotation : CaliperEntity, IThing {

		public Annotation( string id ) {
			this.Id = id;
			this.Type = "http://purl.imsglobal.org/caliper/v1/Annotation";
		}

		[JsonProperty( "target", Order = 21 )]
		public object Target { get; set; }

	}

}
