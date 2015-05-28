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
	public class AssessmentItemCompletedEventsTests {

		[Test]
		public void AssessmentItemCompletedEvent_MatchesReferenceJson() {

			var assessmentItemEvent = new AssessmentItemEvent( Action.Completed ) {
				Actor = TestEntities.Student554433,
				Object = TestEntities.AssessmentItem1,
				Generated = TestEntities.Assessment1_Item1_Attempt1_Response,
				StartedAt = TestEntities.DefaultStartedAtTime,
				EdApp = TestEntities.SuperAssessmentTool,
				Group = TestEntities.AmRev101_Group001,
				Membership = TestEntities.Student554433_AmRev101_CourseSection001_Membership
			};

			JsonAssertions.AssertSameObjectJson( assessmentItemEvent, "caliperAssessmentItemCompletedEvent" );
		}

	}

}
