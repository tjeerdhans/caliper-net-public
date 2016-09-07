﻿using ImsGlobal.Caliper.Events.Reading;
using ImsGlobal.Caliper.Tests.SimpleHelpers;
using NUnit.Framework;

namespace ImsGlobal.Caliper.Tests
{
    [TestFixture]
    public class ViewEventsTests
    {
        [Test]
        public void ViewEvent_MatchesReferenceJson()
        {
            var viewEvent = new ViewEvent
            {
                Actor = TestEntities.User554433,
                Object = TestEntities.EpubVolume43,
                Target = TestEntities.EpubSubChap431_Frame,
                EventTime = TestEntities.DefaultStartedAtTime,
                EdApp = TestEntities.EpubViewerApp,
                Group = TestEntities.AmRev101_Group001,
                Membership = TestEntities.User554433_AmRev101_CourseSection001_Membership
            };

            JsonAssertions.AssertSameObjectJson(viewEvent, "caliperViewEvent");
        }
    }
}