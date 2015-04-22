using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;
using Xunit;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Tests.SimpleHelpers;
	using ImsGlobal.Caliper.Events.Assessment;

	public class AssessmentItemEventsTests {

		[Fact]
		public void AssessmentItemEvent_MatchesReferenceJson() {

			var assessmentItemEvent = new AssessmentItemEvent( Events.Action.Started ) {
				EdApp = TestEntities.SuperAssessmentTool,
				Group = TestEntities.AmRev101,
				Actor = TestEntities.Student554433,
				Object = TestEntities.Assessment1.AssessmentItems[0],
				StartedAt = 1402965614516L
			};

			var eventJson = JObject.FromObject( assessmentItemEvent );
			var refJsonString = TestUtils.LoadReferenceJsonFile( "caliperAssessmentItemEvent" );
			var refJson = JObject.Parse( refJsonString );

			var diff = ObjectDiffPatch.GenerateDiff( refJson, eventJson );

			System.Diagnostics.Trace.WriteLine( diff.NewValues );
			System.Diagnostics.Trace.WriteLine( diff.OldValues );

			Assert.Null( diff.NewValues );
			Assert.Null( diff.OldValues );
		}

	}

}
