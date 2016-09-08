using ImsGlobal.Caliper.Events;
using ImsGlobal.Caliper.Events.Session;
using ImsGlobal.Caliper.Tests.SimpleHelpers;
using Xunit;

namespace ImsGlobal.Caliper.Tests
{
    public class SessionEventsTests
    {
        [Fact]
        public void SessionLoggedInEvent_MatchesReferenceJson()
        {
            var loggedInEvent = new SessionEvent(Action.LoggedIn)
            {
                Actor = TestEntities.User554433,
                Object = TestEntities.EpubViewerApp,
                Target = TestEntities.EpubSubChap431_Frame,
                Generated = TestEntities.SessionStart,
                EventTime = TestEntities.DefaultStartedAtTime,
                EdApp = TestEntities.EpubViewerApp,
                Group = TestEntities.AmRev101_Group001,
                Membership = TestEntities.User554433_AmRev101_CourseSection001_Membership
            };

            JsonAssertions.AssertSameObjectJson(loggedInEvent, "caliperSessionLoginEvent");
        }

        [Fact]
        public void SessionLoggedOutEvent_MatchesReferenceJson()
        {
            var loggedOutEvent = new SessionEvent(Action.LoggedOut)
            {
                Actor = TestEntities.User554433,
                Object = TestEntities.EpubViewerApp,
                Target = TestEntities.SessionEnd,
                EventTime = TestEntities.DefaultStartedAtTime,
                EdApp = TestEntities.EpubViewerApp,
                Group = TestEntities.AmRev101_Group001,
                Membership = TestEntities.User554433_AmRev101_CourseSection001_Membership
            };

            JsonAssertions.AssertSameObjectJson(loggedOutEvent, "caliperSessionLogoutEvent");
        }

        [Fact]
        public void SessionTimedOutEvent_MatchesReferenceJson()
        {
            var timedOutEvent = new SessionEvent(Action.TimedOut)
            {
                Actor = TestEntities.EpubViewerApp,
                Object = TestEntities.SessionEnd,
                EventTime = TestEntities.DefaultStartedAtTime,
                EdApp = TestEntities.EpubViewerApp,
                Group = TestEntities.AmRev101_Group001
            };

            JsonAssertions.AssertSameObjectJson(timedOutEvent, "caliperSessionTimeoutEvent");
        }
    }
}