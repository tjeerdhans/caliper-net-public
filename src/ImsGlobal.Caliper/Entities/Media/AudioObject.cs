using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Media {
	using ImsGlobal.Caliper.Entities.SchemaDotOrg;

	/// <summary>
	/// An audio object embedded in a web page.
	/// </summary>
	public class AudioObject : MediaObject, IAudioObject {

		public AudioObject( string id )
			: base( id, MediaObjectType.AudioObject ) {
		}

	}

}
