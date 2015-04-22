using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Xunit;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Tests.SimpleHelpers;
	using ImsGlobal.Caliper.Events;
	using ImsGlobal.Caliper.Events.Session;

	public class SessionEventsTests {

		[Fact]
		public void SessionLoggedInEvent_MatchesReferenceJson() {

			var loggedInEvent = new SessionEvent( Action.LoggedIn ) {
				EdApp = TestEntities.Readium,
				Group = TestEntities.AmRev101_CourseOffering,
				Actor = TestEntities.Student554433,
				Object = TestEntities.Readium,
				Target = TestEntities.EpubSubChap431_Frame,
				Generated = TestEntities.SessionStart,
				StartedAt = 1402965614516L
			};

			var eventJson = JObject.FromObject( loggedInEvent );
			var refJsonString = TestUtils.LoadReferenceJsonFile( "caliperSessionLoginEvent" );
			var refJson = JObject.Parse( refJsonString );

			var diff = ObjectDiffPatch.GenerateDiff( refJson, eventJson );

			System.Diagnostics.Trace.WriteLine( diff.NewValues );
			System.Diagnostics.Trace.WriteLine( diff.OldValues );

			Assert.Null( diff.NewValues );
			Assert.Null( diff.OldValues );
		}

		[Fact]
		public void SessionLoggedOutEvent_MatchesReferenceJson() {

			var loggedOutEvent = new SessionEvent( Action.LoggedOut ) {
				EdApp = TestEntities.Readium,
				Group = TestEntities.AmRev101_CourseOffering,
				Actor = TestEntities.Student554433,
				Object = TestEntities.Readium,
				Target = TestEntities.SessionEnd,
				StartedAt = 1402965614516L,
				EndedAt = 1402965614516L
			};

			var eventJson = JObject.FromObject( loggedOutEvent );
			var refJsonString = TestUtils.LoadReferenceJsonFile( "caliperSessionLogoutEvent" );
			var refJson = JObject.Parse( refJsonString );

			var diff = ObjectDiffPatch.GenerateDiff( refJson, eventJson );

			System.Diagnostics.Trace.WriteLine( diff.NewValues );
			System.Diagnostics.Trace.WriteLine( diff.OldValues );

			Assert.Null( diff.NewValues );
			Assert.Null( diff.OldValues );
		}

		[Fact]
		public void SessionTimedOutEvent_MatchesReferenceJson() {

			var timedOutEvent = new SessionEvent( Action.TimedOut ) {
				EdApp = TestEntities.Readium,
				Group = TestEntities.AmRev101_CourseOffering,
				Actor = TestEntities.Readium,
				Object = TestEntities.Readium,
				Target = TestEntities.SessionEnd,
				StartedAt = 1402965614516L,
				EndedAt = 1402965614516L
			};

			var eventJson = JObject.FromObject( timedOutEvent );
			var refJsonString = TestUtils.LoadReferenceJsonFile( "caliperSessionTimeoutEvent" );
			var refJson = JObject.Parse( refJsonString );

			var diff = ObjectDiffPatch.GenerateDiff( refJson, eventJson );

			System.Diagnostics.Trace.WriteLine( diff.NewValues );
			System.Diagnostics.Trace.WriteLine( diff.OldValues );

			Assert.Null( diff.NewValues );
			Assert.Null( diff.OldValues );
		}

	}

}
