using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities {
	using ImsGlobal.Caliper.Util;

	[JsonConverter( typeof( JsonValueConverter<DigitalResourceType> ) )]
	public sealed class DigitalResourceType : IType, IJsonValue {

		public static readonly DigitalResourceType AssignableDigitalResource = new DigitalResourceType( "http://purl.imsglobal.org/caliper/v1/AssignableDigitalResource" );
		public static readonly DigitalResourceType EpubChapter = new DigitalResourceType( "http://www.idpf.org/epub/vocab/structure/#chapter" );
		public static readonly DigitalResourceType EpubPart = new DigitalResourceType( "http://www.idpf.org/epub/vocab/structure/#part" );
		public static readonly DigitalResourceType EpubSubChapter = new DigitalResourceType( "http://www.idpf.org/epub/vocab/structure/#subchapter" );
		public static readonly DigitalResourceType EpubVolume = new DigitalResourceType( "http://www.idpf.org/epub/vocab/structure/#volume" );
		public static readonly DigitalResourceType Frame = new DigitalResourceType( "http://purl.imsglobal.org/caliper/v1/Frame" );
		public static readonly DigitalResourceType Reading = new DigitalResourceType( "http://www.idpf.org/epub/vocab/structure" );
		public static readonly DigitalResourceType WebPage = new DigitalResourceType( "http://purl.imsglobal.org/caliper/v1/WebPage" );

		public DigitalResourceType() {}

		public DigitalResourceType( string value ) {
			this.Value = value;
		}

		public string Value { get; set; }

	}

}