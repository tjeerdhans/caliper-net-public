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

		public sealed class DigitalResourceType {

			public static readonly DigitalResourceType AssignableDigitalResource = new DigitalResourceType( "http://purl.imsglobal.org/caliper/v1/AssignableDigitalResource" );
			public static readonly DigitalResourceType EpubChapter = new DigitalResourceType( "http://www.idpf.org/epub/vocab/structure/#chapter" );
			public static readonly DigitalResourceType EpubPart = new DigitalResourceType( "http://www.idpf.org/epub/vocab/structure/#part" );
			public static readonly DigitalResourceType EpubSubChapter = new DigitalResourceType( "http://www.idpf.org/epub/vocab/structure/#subchapter" );
			public static readonly DigitalResourceType EpubVolume = new DigitalResourceType( "http://www.idpf.org/epub/vocab/structure/#volume" );
			public static readonly DigitalResourceType Frame = new DigitalResourceType( "http://purl.imsglobal.org/caliper/v1/Frame" );
			public static readonly DigitalResourceType MediaLocation = new DigitalResourceType( "http://purl.imsglobal.org/caliper/v1/MediaLocation" );
			public static readonly DigitalResourceType MediaObject = new DigitalResourceType( "http://purl.imsglobal.org/caliper/v1/MediaObject" );
			public static readonly DigitalResourceType Reading = new DigitalResourceType( "http://www.idpf.org/epub/vocab/structure" );
			public static readonly DigitalResourceType WebPage = new DigitalResourceType( "http://purl.imsglobal.org/caliper/v1/WebPage" );

			private DigitalResourceType( string uri ) {
				this.Uri = uri;
			}

			public string Uri { get; private set; }
		}

		public DigitalResource( string id )
			: base( id ) {
			this.Type = EntityType.DigitalResource.Uri;
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
		[JsonProperty( "keyword", Order = 13 )]
		public IList<string> Keywords { get; set; }

		/// <summary>
		/// A reference to the parent resource, if any.
		/// </summary>
		[JsonProperty( "partOf", Order = 14 )]
		public dynamic ParentRef { get; set; }

	}

}
