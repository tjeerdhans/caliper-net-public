using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Outcome {

	/// <summary>
	/// Event raised when actions related to an outcome are performed.
	/// </summary>
	public class OutcomeEvent : Event {

		public OutcomeEvent( Action action ) {
			this.Context = EventContext.Outcome.Uri;
			this.Type = EventType.Outcome.Uri;
			this.Action = action.Value;
		}

	}

}
