using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Reading {

	/// <summary>
	/// Representation of an EPUB 3 Chapter.
	/// 
	/// A major structural division of a piece of writing.
	/// http://www.idpf.org/epub/vocab/structure/#chapter
	/// </summary>
	public class EPubChapter : DigitalResource {

		public EPubChapter( string id )
			: base( id ) {
			this.Type = DigitalResourceType.EpubChapter.Uri;
		}

	}

}
