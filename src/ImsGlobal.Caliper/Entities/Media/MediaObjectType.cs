using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Media {
	using ImsGlobal.Caliper.Util;

	[JsonConverter( typeof( JsonValueConverter<MediaObjectType> ) )]
	public sealed class MediaObjectType : IType, IJsonValue {

		public static readonly MediaObjectType AudioObject = new MediaObjectType( "http://purl.imsglobal.org/caliper/v1/AudioObject" );
		public static readonly MediaObjectType ImageObject = new MediaObjectType( "http://purl.imsglobal.org/caliper/v1/ImageObject" );
		public static readonly MediaObjectType VideoObject = new MediaObjectType( "http://purl.imsglobal.org/caliper/v1/VideoObject" );
		public static readonly MediaObjectType MediaLocation = new MediaObjectType( "http://purl.imsglobal.org/caliper/v1/MediaLocation" );

		public MediaObjectType() {}

		public MediaObjectType( string value ) {
			this.Value = value;
		}

		public string Value { get; set; }
	}
}