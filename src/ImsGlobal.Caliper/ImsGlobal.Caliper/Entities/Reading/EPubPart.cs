using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Reading {

	/// <summary>
	/// Representation of an EPUB 3 Part.
	/// 
	/// A major structural division of a piece of writing,
	/// typically encapsulating a set of related chapters.
	/// http://www.idpf.org/epub/vocab/structure/#part
	/// </summary>
	public class EPubPart : DigitalResource {

		public EPubPart( string id )
			: base( id ) {
			this.Type = DigitalResourceType.EpubPart.Uri;
		}

	}

}
