using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Events.Annotation {

	/// <summary>
	/// Event raised when an actor annotates a resource.
	/// </summary>
	public class AnnotationEvent : CaliperEvent {

		public AnnotationEvent( string action )
			: base() {

			this.Context = "http://purl.imsglobal.org/ctx/caliper/v1/AnnotationEvent";
			this.Type = "http://purl.imsglobal.org/caliper/v1/AnnotationEvent";
			this.Action = action;
		}

	}

}
