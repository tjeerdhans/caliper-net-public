using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Tests.SimpleHelpers;
	using ImsGlobal.Caliper.Events;
	using ImsGlobal.Caliper.Events.Outcome;

	public class AssessmentOutcomeEventsTests {

		[Fact]
		public void AssessmentOutcomeEvent_MatchesReferenceJson() {

			var outcomeEvent = new OutcomeEvent( Action.Graded ) {
				EdApp = TestEntities.SuperAssessmentTool,
				Group = TestEntities.AmRev101_Group001,
				Actor = TestEntities.Student554433,
				Object = TestEntities.Assessment1_Attempt1,
				Generated = TestEntities.Assessment1_Attempt1_Result,
				StartedAt = TestEntities.DefaultStartedAtTime
			};

			JsonAssertions.AssertSameEventJson( outcomeEvent, "caliperAssessmentOutcomeEvent" );
		}

	}

}
