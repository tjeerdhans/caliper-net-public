﻿using ImsGlobal.Caliper.Events.Reading;
using ImsGlobal.Caliper.Tests.SimpleHelpers;
using NUnit.Framework;

namespace ImsGlobal.Caliper.Tests
{
    [TestFixture]
    public class NavigationEventsTests
    {
        [Test]
        public void NavigationEvent_MatchesReferenceJson()
        {
            var navigationEvent = new NavigationEvent
            {
                Actor = TestEntities.User554433,
                Object = TestEntities.EpubVolume43,
                Target = TestEntities.EpubSubChap431_Frame,
                FromResource = TestEntities.AmRev101LandingPage,
                EventTime = TestEntities.DefaultStartedAtTime,
                EdApp = TestEntities.EpubViewerApp,
                Group = TestEntities.AmRev101_Group001,
                Membership = TestEntities.User554433_AmRev101_CourseSection001_Membership
            };

            JsonAssertions.AssertSameObjectJson(navigationEvent, "caliperNavigationEvent");
        }
    }
}