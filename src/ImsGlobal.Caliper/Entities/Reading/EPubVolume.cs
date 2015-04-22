using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Reading {

	/// <summary>
	/// Representation of an EPUB 3 Volume.
	/// 
	/// A component of a collection.
	/// http://www.idpf.org/epub/vocab/structure/#volume
	/// </summary>
	public class EPubVolume : DigitalResource {

		public EPubVolume( string id )
			: base( id ) {
			this.Type = DigitalResourceType.EpubVolume;
		}

	}

}
