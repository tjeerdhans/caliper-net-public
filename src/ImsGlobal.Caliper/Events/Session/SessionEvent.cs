using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Session {

	public class SessionEvent : Event {

		public SessionEvent( Action action ) {
			this.Type = EventType.Session;
			this.Action = action;
		}

	}

}
