using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Assessment {

	/// <summary>
	/// Event raised when an actor interacts with an assessment item resource.
	/// </summary>
	public class AssessmentItemEvent : Event {

		public AssessmentItemEvent( Action action ) {
			this.Type = EventType.AssessmentItem;
			this.Action = action;
		}

	}

}
