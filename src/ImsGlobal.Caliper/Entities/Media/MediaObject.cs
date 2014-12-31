using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Media {
	using ImsGlobal.Caliper.Entities.SchemaDotOrg;

	public abstract class MediaObject : DigitalResource, IMediaObject {

		public sealed class MediaType {

			public static readonly MediaType Audio = new MediaType( "http://purl.imsglobal.org/caliper/v1/AudioObject" );
			public static readonly MediaType Image = new MediaType( "http://purl.imsglobal.org/caliper/v1/ImageObject" );
			public static readonly MediaType Video = new MediaType( "http://purl.imsglobal.org/caliper/v1/VideoObject" );

			private MediaType( string uri ) {
				this.Uri = uri;
			}

			public string Uri { get; private set; }
		}

		public MediaObject( string id, MediaType type )
			: base( id ) {
			this.Type = type.Uri;
		}

		[JsonProperty( "duration", Order = 21 )]
		public long Duration { get; set; }

	}

}
