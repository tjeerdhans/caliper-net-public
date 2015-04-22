using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;
using Xunit;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Tests.SimpleHelpers;
	using ImsGlobal.Caliper.Events.Reading;

	public class ReadingEventsTests {

		[Fact]
		public void NavigationEvent_MatchesReferenceJson() {

			var navigationEvent = new NavigationEvent {
				EdApp = TestEntities.Readium,
				Group = TestEntities.AmRev101_CourseOffering,
				Actor = TestEntities.Student554433,
				Object = TestEntities.EpubVolume43,
				Target = TestEntities.EpubSubChap431_Frame,
				FromResource = TestEntities.AmRev101LandingPage,
				StartedAt = 1402965614516L
			};

			var eventJson = JObject.FromObject( navigationEvent );
			var refJsonString = TestUtils.LoadReferenceJsonFile( "caliperNavigationEvent" );
			var refJson = JObject.Parse( refJsonString );

			var diff = ObjectDiffPatch.GenerateDiff( refJson, eventJson );

			System.Diagnostics.Trace.WriteLine( diff.NewValues );
			System.Diagnostics.Trace.WriteLine( diff.OldValues );

			Assert.Null( diff.NewValues );
			Assert.Null( diff.OldValues );
		}

		[Fact]
		public void ViewEvent_MatchesReferenceJson() {

			var viewEvent = new ViewEvent {
				EdApp = TestEntities.Readium,
				Group = TestEntities.AmRev101_CourseOffering,
				Actor = TestEntities.Student554433,
				Object = TestEntities.EpubVolume43,
				Target = TestEntities.EpubSubChap431_Frame,
				StartedAt = 1402965614516L
			};

			var eventJson = JObject.FromObject( viewEvent );
			var refJsonString = TestUtils.LoadReferenceJsonFile( "caliperViewEvent" );
			var refJson = JObject.Parse( refJsonString );

			var diff = ObjectDiffPatch.GenerateDiff( refJson, eventJson );

			System.Diagnostics.Trace.WriteLine( diff.NewValues );
			System.Diagnostics.Trace.WriteLine( diff.OldValues );

			Assert.Null( diff.NewValues );
			Assert.Null( diff.OldValues );
		}

	}

}
