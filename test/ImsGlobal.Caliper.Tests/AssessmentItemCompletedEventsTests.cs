using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Tests.SimpleHelpers;
	using ImsGlobal.Caliper.Events;
	using ImsGlobal.Caliper.Events.Assessment;

	public class AssessmentItemCompletedEventsTests {

		[Fact]
		public void AssessmentItemCompletedEvent_MatchesReferenceJson() {

			var assessmentItemEvent = new AssessmentItemEvent( Action.Completed ) {
				EdApp = TestEntities.SuperAssessmentTool,
				Group = TestEntities.AmRev101_Group001,
				Actor = TestEntities.Student554433,
				Object = TestEntities.Assessment1.AssessmentItems[0],
				Generated = TestEntities.Assessment1_Item1_Attempt1_Response,
				StartedAt = TestEntities.DefaultStartedAtTime
			};

			JsonAssertions.AssertSameObjectJson( assessmentItemEvent, "caliperAssessmentItemCompletedEvent" );
		}

	}

}
