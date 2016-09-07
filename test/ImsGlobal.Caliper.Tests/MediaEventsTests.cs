using ImsGlobal.Caliper.Events;
using ImsGlobal.Caliper.Events.Media;
using ImsGlobal.Caliper.Tests.SimpleHelpers;
using NUnit.Framework;

namespace ImsGlobal.Caliper.Tests
{
    [TestFixture]
    public class MediaEventsTests
    {
        [Test]
        public void MediaEvent_MatchesReferenceJson()
        {
            var mediaEvent = new MediaEvent(Action.Paused)
            {
                Actor = TestEntities.User554433,
                Object = TestEntities.VideoWithLearningObjective,
                Target = TestEntities.VideoWithLearningObjective_Location710,
                EventTime = TestEntities.DefaultStartedAtTime,
                EdApp = TestEntities.SuperMediaTool,
                Group = TestEntities.AmRev101_Group001,
                Membership = TestEntities.User554433_AmRev101_CourseSection001_Membership
            };

            JsonAssertions.AssertSameObjectJson(mediaEvent, "caliperMediaEvent");
        }
    }
}