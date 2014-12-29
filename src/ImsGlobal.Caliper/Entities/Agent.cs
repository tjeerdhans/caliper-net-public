using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities {

	public class Agent : Entity, Foaf.IAgent {

		public sealed class AgentType {

			public static readonly AgentType LisPerson = new AgentType( "http://purl.imsglobal.org/caliper/v1/lis/Person" );
			public static readonly AgentType LisOrganization = new AgentType( "http://purl.imsglobal.org/caliper/v1/lis/Organization" );
			public static readonly AgentType SoftwareApplication = new AgentType( "http://purl.imsglobal.org/caliper/v1/SoftwareApplication" );

			private AgentType( string uri ) {
				this.Uri = uri;
			}

			public string Uri { get; private set; }
		}

		public Agent( string id )
			: base( id ) {
			this.Type = EntityType.Agent.Uri;
		}

	}

}
