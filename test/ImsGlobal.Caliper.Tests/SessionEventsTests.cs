using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Tests.SimpleHelpers;
	using ImsGlobal.Caliper.Events;
	using ImsGlobal.Caliper.Events.Session;

	[TestFixture]
	public class SessionEventsTests {

		[Test]
		public void SessionLoggedInEvent_MatchesReferenceJson() {

			var loggedInEvent = new SessionEvent( Action.LoggedIn ) {
				EdApp = TestEntities.Readium,
				Group = TestEntities.AmRev101_Group001,
				Actor = TestEntities.Student554433,
				Object = TestEntities.Readium,
				Target = TestEntities.EpubSubChap431_Frame,
				Generated = TestEntities.SessionStart,
				StartedAt = TestEntities.DefaultStartedAtTime
			};

			JsonAssertions.AssertSameObjectJson( loggedInEvent, "caliperSessionLoginEvent" );
		}

		[Test]
		public void SessionLoggedOutEvent_MatchesReferenceJson() {

			var loggedOutEvent = new SessionEvent( Action.LoggedOut ) {
				EdApp = TestEntities.Readium,
				Group = TestEntities.AmRev101_Group001,
				Actor = TestEntities.Student554433,
				Object = TestEntities.Readium,
				Target = TestEntities.SessionEnd,
				StartedAt = TestEntities.DefaultStartedAtTime,
				EndedAt = TestEntities.DefaultEndedAtTime,
				Duration = TestEntities.SessionEnd.Duration
			};

			JsonAssertions.AssertSameObjectJson( loggedOutEvent, "caliperSessionLogoutEvent" );
		}

		[Test]
		public void SessionTimedOutEvent_MatchesReferenceJson() {

			var timedOutEvent = new SessionEvent( Action.TimedOut ) {
				EdApp = TestEntities.Readium,
				Group = TestEntities.AmRev101_Group001,
				Actor = TestEntities.Readium,
				Object = TestEntities.Readium,
				Target = TestEntities.SessionEnd,
				StartedAt = TestEntities.DefaultStartedAtTime,
				EndedAt = TestEntities.DefaultEndedAtTime,
				Duration = TestEntities.SessionEnd.Duration
			};

			JsonAssertions.AssertSameObjectJson( timedOutEvent, "caliperSessionTimeoutEvent" );
		}

	}

}
