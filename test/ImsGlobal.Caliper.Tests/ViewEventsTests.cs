using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Tests.SimpleHelpers;
	using ImsGlobal.Caliper.Events.Reading;

	public class ViewEventsTests {

		[Fact]
		public void ViewEvent_MatchesReferenceJson() {

			var viewEvent = new ViewEvent {
				EdApp = TestEntities.Readium,
				Group = TestEntities.AmRev101_Group001,
				Actor = TestEntities.Student554433,
				Object = TestEntities.EpubVolume43,
				Target = TestEntities.EpubSubChap431_Frame,
				StartedAt = TestEntities.DefaultStartedAtTime
			};

			JsonAssertions.AssertSameEventJson( viewEvent, "caliperViewEvent" );
		}

	}

}
