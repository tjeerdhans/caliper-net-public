using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Assessment {

	public sealed class AssessmentAction {

		public static readonly AssessmentAction Started = new AssessmentAction( "started" );
		public static readonly AssessmentAction Paused = new AssessmentAction( "paused" );
		public static readonly AssessmentAction Restarted = new AssessmentAction( "restarted" );
		public static readonly AssessmentAction Submitted = new AssessmentAction( "submitted" );

		private AssessmentAction( string action ) {
			this.Value = action;
		}

		public string Value { get; private set; }

	}

}

