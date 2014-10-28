using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities {
	using ImsGlobal.Caliper.Entities.SchemaDotOrg;

	public class CaliperDigitalResource : CaliperEntity, ICreativeWork {

		public CaliperDigitalResource() {
			this.AlignedLearningObjectives = new List<LearningObjective>();
			this.Keywords = new List<string>();
		}

		/// <summary>
		/// The name of the resource.
		/// </summary>
		[JsonProperty( "name", Order = 11 )]
		public string Name { get; set; }

		/// <summary>
		/// List of learning objectives aligned with this resource.
		/// </summary>
		[JsonProperty( "alignedLearningObjective", Order = 12 )]
		public IList<LearningObjective> AlignedLearningObjectives { get; set; }

		/// <summary>
		/// List of keywords that describe this resource.
		/// </summary>
		[JsonProperty( "keyword", Order = 13 )]
		public IList<string> Keywords { get; set; }

		/// <summary>
		/// The object type of the resource.
		/// </summary>
		[JsonProperty( "objectType", Order = 14 )]
		public dynamic ObjectType { get; set; }

		/// <summary>
		/// A reference to the parent resource, if any.
		/// </summary>
		[JsonProperty( "partOf", Order = 15 )]
		public dynamic ParentRef { get; set; }

	}

}
