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
	/// A Caliper sensor for sending events and entities to a Caliper endpoint.
	/// </summary>
	public class CaliperSensor {

		private readonly CaliperClient _client;

		public CaliperSensor( CaliperOptions options ) {
			if( options == null ) {
				throw new ArgumentNullException( "options" );
			}

			_client = new CaliperClient( options );
		}

		/// <summary>
		/// Sends an event to the configured Caliper endpoint.
		/// </summary>
		/// <param name="event">The CaliperEvent to be sent.</param>
		public async Task<bool> SendAsync( Event @event ) {
			return await _client.Send( @event );
		}

		/// <summary>
		/// Sends an entity to the configured Caliper endpoint.
		/// </summary>
		/// <param name="entity">The CaliperEntity to be sent.</param>
		public async Task<bool> Describe( Entity entity ) {
			return await _client.Describe( entity );
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
