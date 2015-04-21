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
	public class Annotation : Entity, IThing {

		public sealed class AnnotationType {

			public static readonly AnnotationType Bookmark = new AnnotationType( "http://purl.imsglobal.org/caliper/v1/BookmarkAnnotation" );
			public static readonly AnnotationType Highlight = new AnnotationType( "http://purl.imsglobal.org/caliper/v1/HighlightAnnotation" );
			public static readonly AnnotationType Share = new AnnotationType( "http://purl.imsglobal.org/caliper/v1/SharedAnnotation" );
			public static readonly AnnotationType Tag = new AnnotationType( "http://purl.imsglobal.org/caliper/v1/TagAnnotation" );

			private AnnotationType( string uri ) {
				this.Uri = uri;
			}

			public string Uri { get; private set; }
		}

		public Annotation( string id )
			: base( id ) {
			this.Type = EntityType.Annotation.Uri;
		}

		[JsonIgnore]
		[JsonProperty( "target", Order = 21 )]
		public object Target { get; set; }

	}

}
