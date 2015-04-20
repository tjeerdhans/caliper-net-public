using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Reading {

	/// <summary>
	/// Event raised when an actor views a resource.
	/// </summary>
	public class ViewEvent : Event {

		public ViewEvent() {
			this.Context = EventContext.View.Uri;
			this.Type = EventType.View.Uri;
			this.Action = Events.Action.Viewed.Value;
		}

	}
}
