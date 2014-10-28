using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Reading {
	using ImsGlobal.Caliper.Entities.SchemaDotOrg;

	/// <summary>
	/// Representation of an EPUB 3 Part.
	/// 
	/// A major structural division of a piece of writing,
	/// typically encapsulating a set of related chapters.
	/// 
	/// http://www.idpf.org/epub/vocab/structure/#part
	/// </summary>
	public class EPubPart : CaliperDigitalResource, ICreativeWork {

		public EPubPart( string id )
			: base() {

			this.Id = id;
			this.Type = "http://www.idpf.org/epub/vocab/structure/#part";
		}

	}

}
