using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Session {

	public sealed class SessionAction {

		public static readonly SessionAction LoggedIn = new SessionAction( "logged in" );
		public static readonly SessionAction LoggedOut = new SessionAction( "logged out" );
		public static readonly SessionAction TimedOut = new SessionAction( "timed out" );

		private SessionAction( string action ) {
			this.Value = action;
		}

		public string Value { get; private set; }

	}

}

