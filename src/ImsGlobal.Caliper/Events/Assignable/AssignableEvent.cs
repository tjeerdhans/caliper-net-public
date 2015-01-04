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

		public AssignableEvent( AssignableAction action ) {
			this.Context = EventContext.Assignable.Uri;
			this.Type = EventType.Assignable.Uri;
			this.Action = action.Value;
		}

	}

}
