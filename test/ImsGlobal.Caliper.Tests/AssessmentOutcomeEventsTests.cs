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
	using ImsGlobal.Caliper.Events.Outcome;

	public class AssessmentOutcomeEventsTests {

		[Fact]
		public void AssessmentOutcomeEvent_MatchesReferenceJson() {

			var outcomeEvent = new OutcomeEvent( OutcomeAction.Graded ) {
				EdApp = TestEntities.SuperAssessmentTool,
				LisOrg = TestEntities.AmRev101,
				Actor = TestEntities.Student554433,
				Object = TestEntities.Assessment1_Attempt1,
				Generated = TestEntities.Assessment1_Attempt1_Result,
				StartedAt = 1402965614516L
			};

			var eventJson = JObject.FromObject( outcomeEvent );
			var refJsonString = TestUtils.LoadReferenceJsonFile( "caliperAssessmentOutcomeEvent" );
			var refJson = JObject.Parse( refJsonString );

			var diff = ObjectDiffPatch.GenerateDiff( refJson, eventJson );

			System.Diagnostics.Trace.WriteLine( diff.NewValues );
			System.Diagnostics.Trace.WriteLine( diff.OldValues );

			Assert.Null( diff.NewValues );
			Assert.Null( diff.OldValues );
		}

	}

}
