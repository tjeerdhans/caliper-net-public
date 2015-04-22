using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Annotation {
	using ImsGlobal.Caliper.Util;

	[JsonConverter( typeof( JsonValueConverter<AnnotationType> ) )]
	public sealed class AnnotationType : IType, IJsonValue {

		public static readonly AnnotationType Bookmark = new AnnotationType( "http://purl.imsglobal.org/caliper/v1/BookmarkAnnotation" );
		public static readonly AnnotationType Highlight = new AnnotationType( "http://purl.imsglobal.org/caliper/v1/HighlightAnnotation" );
		public static readonly AnnotationType Share = new AnnotationType( "http://purl.imsglobal.org/caliper/v1/SharedAnnotation" );
		public static readonly AnnotationType Tag = new AnnotationType( "http://purl.imsglobal.org/caliper/v1/TagAnnotation" );

		public AnnotationType() {}

		public AnnotationType( string uri ) {
			this.Value = uri;
		}

		public string Value { get; set; }

	}

}