using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Assignable {

	/// <summary>
	/// Event raised when an actor interacts with an assignable resource.
	/// </summary>
	public class AssignableEvent : Event {

		public AssignableEvent( Action action ) {
			this.Type = EventType.Assignable;
			this.Action = action;
		}

	}

}
