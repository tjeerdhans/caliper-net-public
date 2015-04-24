using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Tests.SimpleHelpers;
	using ImsGlobal.Caliper.Events.Reading;

	public class NavigationEventsTests {

		[Fact]
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

			JsonAssertions.AssertSameEventJson( navigationEvent, "caliperNavigationEvent" );
		}

	}

}
