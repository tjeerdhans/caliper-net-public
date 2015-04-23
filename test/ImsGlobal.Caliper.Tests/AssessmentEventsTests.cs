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

	public class AssessmentEventsTests {

		[Fact]
		public void AssessmentEvent_MatchesReferenceJson() {

			var assessmentEvent = new AssessmentEvent( Action.Started ) {
				EdApp = TestEntities.SuperAssessmentTool,
				Group = TestEntities.AmRev101_Group001,
				Actor = TestEntities.Student554433,
				Object = TestEntities.Assessment1,
				Generated = TestEntities.Assessment1_Attempt1,
				StartedAt = TestEntities.DefaultStartedAtTime
			};

			JsonAssertions.AssertSameEventJson( assessmentEvent, "caliperAssessmentEvent" );
		}

	}

}
