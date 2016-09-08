using ImsGlobal.Caliper.Events;
using ImsGlobal.Caliper.Events.Assignable;
using ImsGlobal.Caliper.Tests.SimpleHelpers;
using Xunit;

namespace ImsGlobal.Caliper.Tests
{
    public class AssignableEventsTests
    {
        [Fact]
        public void AssignableEvent_MatchesReferenceJson()
        {
            var assignableEvent = new AssignableEvent(Action.Activated)
            {
                Actor = TestEntities.User554433,
                Object = TestEntities.Assessment1,
                Generated = TestEntities.Assessment1_Attempt1,
                EventTime = TestEntities.DefaultStartedAtTime,
                EdApp = TestEntities.SuperAssessmentTool,
                Group = TestEntities.AmRev101_Group001,
                Membership = TestEntities.User554433_AmRev101_CourseSection001_Membership
            };

            JsonAssertions.AssertSameObjectJson(assignableEvent, "caliperAssignableEvent");
        }
    }
}