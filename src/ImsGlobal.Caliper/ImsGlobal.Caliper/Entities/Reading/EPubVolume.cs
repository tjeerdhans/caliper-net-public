using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Reading {
	using ImsGlobal.Caliper.Entities.SchemaDotOrg;

	/// <summary>
	/// Representation of an EPUB 3 Volume.
	/// 
	/// A component of a collection.
	/// 
	/// http://www.idpf.org/epub/vocab/structure/#volume
	/// </summary>
	public class EPubVolume : CaliperDigitalResource, ICreativeWork {

		public EPubVolume( string id )
			: base() {

			this.Id = id;
			this.Type = "http://www.idpf.org/epub/vocab/structure/#volume";
		}

	}

}
