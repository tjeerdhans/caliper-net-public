using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Tests.SimpleHelpers;
	using ImsGlobal.Caliper.Events.Reading;

	[TestFixture]
	public class NavigationEventsTests {

		[Test]
		public void NavigationEvent_MatchesReferenceJson() {

			var navigationEvent = new NavigationEvent {
				EdApp = TestEntities.Readium,
				Group = TestEntities.AmRev101_Group001,
				Actor = TestEntities.Student554433,
				Object = TestEntities.EpubVolume43,
				Target = TestEntities.EpubSubChap431_Frame,
				FromResource = TestEntities.AmRev101LandingPage,
				StartedAt = TestEntities.DefaultStartedAtTime
			};

			JsonAssertions.AssertSameObjectJson( navigationEvent, "caliperNavigationEvent" );
		}

	}

}
