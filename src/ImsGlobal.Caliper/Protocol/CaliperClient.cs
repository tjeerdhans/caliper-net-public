using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Protocol {
	using ImsGlobal.Caliper.Entities;
	using ImsGlobal.Caliper.Events;

	internal class CaliperClient {

		private readonly CaliperEndpointOptions _options;

		public CaliperClient( CaliperEndpointOptions options ) {
			_options = options;
		}

		public async Task<bool> Send( Event @event ) {

			var message = new CaliperMessage {
				Id = "caliper-net_" + Guid.NewGuid(),
				Time = DateTime.UtcNow.ToString( "s", System.Globalization.CultureInfo.InvariantCulture ),
				Type = "caliperEvent",
				Data = @event
			};

			using( var client = new HttpClient() ) {

				client.BaseAddress = _options.Host;
				try {

					HttpResponseMessage response = client.PostAsJsonAsync( "", message ).Result;
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
