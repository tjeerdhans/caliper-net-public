using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NodaTime;
using NodaTime.Serialization.JsonNet;
using Xunit;

namespace ImsGlobal.Caliper.Tests.SimpleHelpers {
	using ImsGlobal.Caliper.Events;

	internal static class JsonAssertions {

		private static readonly JsonSerializerSettings _serializerSettings;

		static JsonAssertions() {
			_serializerSettings = new JsonSerializerSettings();
			_serializerSettings.ConfigureForNodaTime( DateTimeZoneProviders.Tzdb );
		}

		public static void AssertSameEventJson( Event @event, string eventReferenceFile ) {

			var eventJsonString = JsonConvert.SerializeObject( @event, _serializerSettings );
			var eventJObject = JObject.Parse( eventJsonString );
			var refJsonString = TestUtils.LoadReferenceJsonFile( eventReferenceFile );
			var refJObject = JObject.Parse( refJsonString );

			var diff = ObjectDiffPatch.GenerateDiff( refJObject, eventJObject );

			Trace.WriteLine( diff.NewValues );
			Trace.WriteLine( diff.OldValues );

			Assert.Null( diff.NewValues );
			Assert.Null( diff.OldValues );
		}
	}
}
