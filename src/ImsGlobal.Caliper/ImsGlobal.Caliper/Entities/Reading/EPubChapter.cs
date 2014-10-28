using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Reading {
	using ImsGlobal.Caliper.Entities.SchemaDotOrg;

	/// <summary>
	/// Representation of an EPUB 3 Chapter.
	/// 
	/// A major structural division of a piece of writing.
	/// 
	/// http://www.idpf.org/epub/vocab/structure/#chapter
	/// </summary>
	public class EPubChapter : CaliperDigitalResource, ICreativeWork {

		public EPubChapter( string id )
			: base() {

			this.Id = id;
			this.Type = "http://www.idpf.org/epub/vocab/structure/#chapter";
		}

	}

}
