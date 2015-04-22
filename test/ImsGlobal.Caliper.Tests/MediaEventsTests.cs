using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;
using Xunit;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Tests.SimpleHelpers;
	using ImsGlobal.Caliper.Events;
	using ImsGlobal.Caliper.Events.Media;

	public class MediaEventsTests {

		[Fact]
		public void MediaEvent_MatchesReferenceJson() {

			var mediaEvent = new MediaEvent( Action.Paused ) {
				EdApp = TestEntities.SuperMediaTool,
				Group = TestEntities.AmRev101_Group001,
				Actor = TestEntities.Student554433,
				Object = TestEntities.VideoWithLearningObjective,
				Target = TestEntities.VideoWithLearningObjective_Location710,
				StartedAt = TestEntities.DefaultStartedAtTime
			};

			var eventJson = JObject.FromObject( mediaEvent );
			var refJsonString = TestUtils.LoadReferenceJsonFile( "caliperMediaEvent" );
			var refJson = JObject.Parse( refJsonString );

			var diff = ObjectDiffPatch.GenerateDiff( refJson, eventJson );

			System.Diagnostics.Trace.WriteLine( diff.NewValues );
			System.Diagnostics.Trace.WriteLine( diff.OldValues );

			Assert.Null( diff.NewValues );
			Assert.Null( diff.OldValues );
		}

	}

}
