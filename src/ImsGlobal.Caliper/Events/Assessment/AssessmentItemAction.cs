using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Assessment {

	public sealed class AssessmentItemAction {

		public static readonly AssessmentItemAction Started = new AssessmentItemAction( "started" );
		public static readonly AssessmentItemAction Completed = new AssessmentItemAction( "completed" );
		public static readonly AssessmentItemAction Skipped = new AssessmentItemAction( "skipped" );
		public static readonly AssessmentItemAction Reviewed = new AssessmentItemAction( "reviewed" );
		public static readonly AssessmentItemAction Viewed = new AssessmentItemAction( "viewed" );

		private AssessmentItemAction( string action ) {
			this.Value = action;
		}

		public string Value { get; private set; }

	}

}

