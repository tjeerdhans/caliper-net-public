using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using NodaTime;
using NodaTime.Serialization.JsonNet;

namespace ImsGlobal.Caliper.Protocol {
	using ImsGlobal.Caliper.Entities;
	using ImsGlobal.Caliper.Events;

	internal class CaliperClient {

		private readonly CaliperEndpointOptions _options;
		private readonly JsonSerializerSettings _serializerSettings;

		public CaliperClient( CaliperEndpointOptions options ) {
			_options = options;
			_serializerSettings = new JsonSerializerSettings();
			_serializerSettings.ConfigureForNodaTime( DateTimeZoneProviders.Tzdb );
		}

		public async Task<bool> Send( Event @event ) {

			var message = new CaliperMessage {
				Id = "caliper-net_" + Guid.NewGuid(),
				Time = SystemClock.Instance.Now,
				Type = "caliperEvent",
				Data = @event
			};
			string json = JsonConvert.SerializeObject( message, _serializerSettings );
			var content = new StringContent( json, Encoding.UTF8, "application/json" );

			using( var client = new HttpClient() ) {

				client.BaseAddress = _options.Host;
				try {

					HttpResponseMessage response = await client.PostAsync( "", content );
					response.EnsureSuccessStatusCode();

				} catch( HttpRequestException ex ) {
					var msg = String.Format( "Failed to send event: {0}", ex.Message );
					Trace.WriteLine( msg );
					return false;
				}
			}

			return true;
		}

		public async Task<bool> Describe( Entity entity ) {
			return false;
		}

	}

}
