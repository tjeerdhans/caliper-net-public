using ImsGlobal.Caliper.Events;
using ImsGlobal.Caliper.Events.Assessment;
using ImsGlobal.Caliper.Tests.SimpleHelpers;
using NUnit.Framework;

namespace ImsGlobal.Caliper.Tests
{
    [TestFixture]
    public class AssessmentItemCompletedEventsTests
    {
        [Test]
        public void AssessmentItemCompletedEvent_MatchesReferenceJson()
        {
            var assessmentItemEvent = new AssessmentItemEvent(Action.Completed)
            {
                Actor = TestEntities.User554433,
                Object = TestEntities.AssessmentItem1,
                Generated = TestEntities.Assessment1_Item1_Attempt1_Response,
                EventTime = TestEntities.DefaultStartedAtTime,
                EdApp = TestEntities.SuperAssessmentTool,
                Group = TestEntities.AmRev101_Group001,
                Membership = TestEntities.User554433_AmRev101_CourseSection001_Membership
            };

            JsonAssertions.AssertSameObjectJson(assessmentItemEvent, "caliperAssessmentItemCompletedEvent");
        }
    }
}