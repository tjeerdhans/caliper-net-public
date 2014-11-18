using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Reading {

	/// <summary>
	/// Representation of an EPUB 3 Sub-chapter.
	/// 
	/// A major sub-division of a chapter.
	/// http://www.idpf.org/epub/vocab/structure/#subchapter
	/// </summary>
	public class EPubSubChapter : DigitalResource {

		public EPubSubChapter( string id )
			: base( id ) {
			this.Type = DigitalResourceType.EpubSubChapter.Uri;
		}

	}

}
