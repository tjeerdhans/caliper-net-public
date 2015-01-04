using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Assignable {

	public sealed class AssignableAction {

		public static readonly AssignableAction Abandoned = new AssignableAction( "abandoned" );
		public static readonly AssignableAction Activated = new AssignableAction( "activated" );
		public static readonly AssignableAction Completed = new AssignableAction( "completed" );
		public static readonly AssignableAction Deactivated = new AssignableAction( "deactivated" );
		public static readonly AssignableAction Hid = new AssignableAction( "hid" );
		public static readonly AssignableAction Reviewed = new AssignableAction( "reviewed" );
		public static readonly AssignableAction Showed = new AssignableAction( "showed" );
		public static readonly AssignableAction Started = new AssignableAction( "started" );
		public static readonly AssignableAction Submitted = new AssignableAction( "submitted" );

		private AssignableAction( string action ) {
			this.Value = action;
		}

		public string Value { get; private set; }

	}

}

