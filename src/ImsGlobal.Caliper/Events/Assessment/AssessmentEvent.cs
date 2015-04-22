using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Assessment {

	/// <summary>
	/// Event raised when an actor interacts with an assessment resource.
	/// </summary>
	public class AssessmentEvent : Event {

		public AssessmentEvent( Action action ) {
			this.Context = EventContext.Assessment;
			this.Type = EventType.Assessment;
			this.Action = action;
		}

	}

}
