using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Media {
	using ImsGlobal.Caliper.Entities.SchemaDotOrg;

	public abstract class MediaObject : DigitalResource, IMediaObject {

		public sealed class MediaObjectType {

			public static readonly MediaObjectType AudioObject = new MediaObjectType( "http://purl.imsglobal.org/caliper/v1/AudioObject" );
			public static readonly MediaObjectType ImageObject = new MediaObjectType( "http://purl.imsglobal.org/caliper/v1/ImageObject" );
			public static readonly MediaObjectType VideoObject = new MediaObjectType( "http://purl.imsglobal.org/caliper/v1/VideoObject" );
			public static readonly MediaObjectType MediaLocation = new MediaObjectType( "http://purl.imsglobal.org/caliper/v1/MediaLocation" );

			private MediaObjectType( string uri ) {
				this.Uri = uri;
			}

			public string Uri { get; private set; }
		}

		public MediaObject( string id )
			: base( id ) {
			this.Type = EntityType.MediaObject.Uri;
		}

		public MediaObject( string id, MediaObjectType type )
			: base( id ) {
			this.Type = type.Uri;
		}

		[JsonProperty( "duration", Order = 71 )]
		public long Duration { get; set; }

	}

}
