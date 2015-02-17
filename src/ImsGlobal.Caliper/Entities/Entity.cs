using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities {

	/// <summary>
	/// The base Caliper Entity. Analogous to a schema.org Thing.
	/// </summary>
	public class Entity {

		public sealed class EntityType {

			public static readonly EntityType ActivityContext = new EntityType( "http://purl.imsglobal.org/caliper/v1/ActivityContext" );
			public static readonly EntityType Agent = new EntityType( "http://purl.imsglobal.org/caliper/v1/Agent" );
			public static readonly EntityType Attempt = new EntityType( "http://purl.imsglobal.org/caliper/v1/Attempt" );
			public static readonly EntityType DigitalResource = new EntityType( "http://purl.imsglobal.org/caliper/v1/DigitalResource" );
			public static readonly EntityType Entity = new EntityType( "http://purl.imsglobal.org/caliper/v1/Entity" );
			public static readonly EntityType LearningObjective = new EntityType( "http://purl.imsglobal.org/caliper/v1/LearningObjective" );
			public static readonly EntityType LisPerson = new EntityType( "http://purl.imsglobal.org/caliper/v1/lis/Person" );
			public static readonly EntityType LisOrganization = new EntityType( "http://purl.imsglobal.org/caliper/v1/lis/Organization" );
			public static readonly EntityType MediaLocation = new EntityType( "http://purl.imsglobal.org/caliper/v1/MediaLocation" );
			public static readonly EntityType Result = new EntityType( "http://purl.imsglobal.org/caliper/v1/Result" );
			public static readonly EntityType Session = new EntityType( "http://purl.imsglobal.org/caliper/v1/Session" );
			public static readonly EntityType SoftwareApplication = new EntityType( "http://purl.imsglobal.org/caliper/v1/SoftwareApplication" );
			public static readonly EntityType View = new EntityType( "http://purl.imsglobal.org/caliper/v1/View" );

			private EntityType( string uri ) {
				this.Uri = uri;
			}

			public string Uri { get; private set; }
		}

		public Entity( string id ) {
			this.Id = id;
			this.Type = EntityType.Entity.Uri;
		}

		[JsonProperty( "@id", Order = 1 )]
		public string Id { get; set; }

		[JsonProperty( "@type", Order = 2 )]
		public string Type { get; set; }

		[JsonProperty( "name", Order = 3 )]
		public string Name { get; set; }

		[JsonProperty( "lastModifiedTime", Order = 99 )]
		public long LastModifiedAt { get; set; }

		[JsonIgnore]
		[JsonProperty( "properties", Order = 99 )]
		public dynamic Properties { get; set; }

	}

}
