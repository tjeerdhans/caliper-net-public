using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Media {

	public class MediaLocation : DigitalResource {

		public MediaLocation( string id )
			: base( id ) {
			this.Type = DigitalResource.DigitalResourceType.MediaLocation.Uri;
		}

		/// <summary>
		/// The time value (from beginning of media) that indicates the
		/// current location.
		/// </summary>
		[JsonProperty( "currentTime", Order = 21 )]
		public long CurrentTime { get; set; }

	}

}
