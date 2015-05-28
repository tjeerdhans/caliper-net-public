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
	public class AssessmentItemStartedEventsTests {

		[Test]
		public void AssessmentItemStartedEvent_MatchesReferenceJson() {

			var assessmentItemEvent = new AssessmentItemEvent( Action.Started ) {
				EdApp = TestEntities.SuperAssessmentTool,
				Group = TestEntities.AmRev101_Group001,
				Actor = TestEntities.Student554433,
				Object = TestEntities.AssessmentItem1,
				Generated = TestEntities.Assessment1_Item1_Attempt1,
				StartedAt = TestEntities.DefaultStartedAtTime
			};

			JsonAssertions.AssertSameObjectJson( assessmentItemEvent, "caliperAssessmentItemStartedEvent" );
		}

	}

}
