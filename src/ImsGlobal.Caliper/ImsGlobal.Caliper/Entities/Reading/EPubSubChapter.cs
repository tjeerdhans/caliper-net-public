using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Reading {
	using ImsGlobal.Caliper.Entities.SchemaDotOrg;

	/// <summary>
	/// Representation of an EPUB 3 Sub-chapter.
	/// 
	/// A major sub-division of a chapter.
	/// 
	/// http://www.idpf.org/epub/vocab/structure/#subchapter
	/// </summary>
	public class EPubSubChapter : CaliperDigitalResource, ICreativeWork {

		public EPubSubChapter( string id )
			: base() {

			this.Id = id;
			this.Type = "http://www.idpf.org/epub/vocab/structure/#subchapter";
		}

	}

}
