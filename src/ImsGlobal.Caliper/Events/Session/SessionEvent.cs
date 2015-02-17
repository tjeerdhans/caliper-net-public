using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Session {

	public class SessionEvent : Event {

		public SessionEvent( SessionAction action ) {
			this.Context = EventContext.Session.Uri;
			this.Type = EventType.Session.Uri;
			this.Action = action.Value;
		}

	}

}
