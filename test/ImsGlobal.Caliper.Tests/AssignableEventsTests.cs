using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;
using Xunit;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Tests.SimpleHelpers;
	using ImsGlobal.Caliper.Events.Assignable;

	public class AssignableEventsTests {

		[Fact]
		public void AssignableEvent_MatchesReferenceJson() {

			var assignableEvent = new AssignableEvent( Events.Action.Activated ) {
				EdApp = TestEntities.SuperAssessmentTool,
				Group = TestEntities.AmRev101,
				Actor = TestEntities.Student554433,
				Object = TestEntities.Assessment1,
				Generated = TestEntities.Assessment1_Attempt1,
				StartedAt = 1402965614516L
			};

			var eventJson = JObject.FromObject( assignableEvent );
			var refJsonString = TestUtils.LoadReferenceJsonFile( "caliperAssignableEvent" );
			var refJson = JObject.Parse( refJsonString );

			var diff = ObjectDiffPatch.GenerateDiff( refJson, eventJson );

			System.Diagnostics.Trace.WriteLine( diff.NewValues );
			System.Diagnostics.Trace.WriteLine( diff.OldValues );

			Assert.Null( diff.NewValues );
			Assert.Null( diff.OldValues );
		}

	}

}
