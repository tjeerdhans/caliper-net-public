using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Tests.SimpleHelpers;
	using ImsGlobal.Caliper.Events;
	using ImsGlobal.Caliper.Events.Media;

	[TestFixture]
	public class MediaEventsTests {

		[Test]
		public void MediaEvent_MatchesReferenceJson() {

			var mediaEvent = new MediaEvent( Action.Paused ) {
				EdApp = TestEntities.SuperMediaTool,
				Group = TestEntities.AmRev101_Group001,
				Actor = TestEntities.Student554433,
				Object = TestEntities.VideoWithLearningObjective,
				Target = TestEntities.VideoWithLearningObjective_Location710,
				StartedAt = TestEntities.DefaultStartedAtTime
			};

			JsonAssertions.AssertSameObjectJson( mediaEvent, "caliperMediaEvent" );
		}

	}

}
