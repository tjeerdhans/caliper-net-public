using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities {
	using ImsGlobal.Caliper.Entities.SchemaDotOrg;

	/// <summary>
	/// Caliper representation of a CreativeWork (https://schema.org/CreativeWork)
	/// 
	/// We add learning specific attributes, including a list of
	/// <see cref="LearningObjective"/> learning objectives and a list of
	/// <see cref="String"/> keywords.
	/// </summary>
	public class DigitalResource : Entity, ICreativeWork {
		public DigitalResource( string id )
			: base( id ) {
			this.Type = EntityType.DigitalResource;
			this.ObjectTypes = new List<string>();
			this.AlignedLearningObjectives = new List<LearningObjective>();
			this.Keywords = new List<string>();
		}

		/// <summary>
		/// The object type of the resource.
		/// </summary>
		[JsonProperty( "objectType", Order = 11 )]
		public IList<string> ObjectTypes { get; set; }

		/// <summary>
		/// List of learning objectives aligned with this resource.
		/// </summary>
		[JsonProperty( "alignedLearningObjective", Order = 12 )]
		public IList<LearningObjective> AlignedLearningObjectives { get; set; }

		/// <summary>
		/// List of keywords that describe this resource.
		/// </summary>
		[JsonProperty( "keywords", Order = 13 )]
		public IList<string> Keywords { get; set; }

		/// <summary>
		/// A reference to the parent resource, if any.
		/// </summary>
		[JsonProperty( "isPartOf", Order = 61 )]
		public object IsPartOf { get; set; }

		/// <summary>
		/// The date the digital resource was published.
		/// </summary>
		[JsonProperty( "datePublished", Order = 62 )]
		public long DatePublished { get; set; }

		/// <summary>
		/// The current version of the digital resource.
		/// </summary>
		[JsonProperty( "version", Order = 63 )]
		public long Version { get; set; }

	}
}
