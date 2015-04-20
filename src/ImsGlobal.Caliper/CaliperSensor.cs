using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper {
	using ImsGlobal.Caliper.Entities;
	using ImsGlobal.Caliper.Events;
	using ImsGlobal.Caliper.Protocol;

	/// <summary>
	/// A Caliper sensor for sending events and entities to Caliper endpoints.
	/// </summary>
	public class CaliperSensor {

		private readonly Dictionary<string, CaliperClient> _clients = new Dictionary<string, CaliperClient>();

		/// <summary>
		/// Registers a new Caliper endpoint with the sensor.
		/// </summary>
		/// <param name="options">The Caliper endpoint options.</param>
		/// <returns>A unique identifier for the endpoint.</returns>
		public string RegisterEndpoint( CaliperEndpointOptions options ) {
			if( options == null ) {
				throw new ArgumentNullException( "options" );
			}

			string endpointId = "caliper-endpoint_" + Guid.NewGuid().ToString( "N" );
			_clients.Add( endpointId, new CaliperClient( options ) );
			return endpointId;
		}

		/// <summary>
		/// Sends an event to the all configured Caliper endpoints.
		/// </summary>
		/// <param name="event">The event to be sent.</param>
		public async Task<bool> SendAsync( Event @event ) {
			var tasks = _clients.Values.Select( c => c.Send( @event ) );
			var results = await Task.WhenAll( tasks );
			return results.All( c => c );
		}

		/// <summary>
		/// Sends an event to a specific Caliper endpoint.
		/// </summary>
		/// <param name="event">The event to be sent.</param>
		/// <param name="endpointId">The Caliper endpoint identifier.</param>
		public async Task<bool> SendAsync( Event @event, string endpointId ) {
			CaliperClient client;
			if( !_clients.TryGetValue( endpointId, out client ) ) {
				return false;
			}
			return await client.Send( @event );
		}

		/// <summary>
		/// Sends an entity to the configured Caliper endpoint.
		/// </summary>
		/// <param name="entity">The entity to be sent.</param>
		public async Task<bool> Describe( Entity entity ) {
			var tasks = _clients.Values.Select( c => c.Describe( entity ) );
			var results = await Task.WhenAll( tasks );
			return results.All( c => c );
		}

		/// <summary>
		/// Sends an entity to a specific Caliper endpoint.
		/// </summary>
		/// <param name="entity">The entity to be sent.</param>
		/// <param name="endpointId">The Caliper endpoint identifier.</param>
		public async Task<bool> Describe( Entity entity, string endpointId ) {
			CaliperClient client;
			if( !_clients.TryGetValue( endpointId, out client ) ) {
				return false;
			}
			return await client.Describe( entity );
		}

		/// <summary>
		/// Retrieves current statistics about sent events and entities.
		/// </summary>
		/// <returns>The current statistics.</returns>
		//public CaliperStatistics GetStatistics() {
		//	return _client.GetStatistics();
		//}

	}

}
