using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Reading {

	/// <summary>
	/// Event raised when an actor views a resource.
	/// </summary>
	public class ViewedEvent : CaliperEvent {

		public ViewedEvent()
			: base() {

			this.Context = "http://purl.imsglobal.org/ctx/caliper/v1/ViewedEvent";
			this.Type = "http://purl.imsglobal.org/caliper/v1/ViewedEvent";
			this.Action = "viewed";
		}

	}

}
