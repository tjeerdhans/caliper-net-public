using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Tests.SimpleHelpers;
	using ImsGlobal.Caliper.Events;
	using ImsGlobal.Caliper.Events.Assessment;

	[TestFixture]
	public class AssessmentEventsTests {

		[Test]
		public void AssessmentEvent_MatchesReferenceJson() {

			var assessmentEvent = new AssessmentEvent( Action.Started ) {
				Actor = TestEntities.User554433,
				Object = TestEntities.Assessment1,
				Generated = TestEntities.Assessment1_Attempt1,
				EventTime = TestEntities.DefaultStartedAtTime,
				EdApp = TestEntities.SuperAssessmentTool,
				Group = TestEntities.AmRev101_Group001,
				Membership = TestEntities.User554433_AmRev101_CourseSection001_Membership
			};

			JsonAssertions.AssertSameObjectJson( assessmentEvent, "caliperAssessmentEvent" );
		}

	}

}
