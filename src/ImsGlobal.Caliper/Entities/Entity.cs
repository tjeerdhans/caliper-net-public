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

			public static readonly EntityType Agent = new EntityType( "http://purl.imsglobal.org/caliper/v1/Agent" );
			public static readonly EntityType Annotation = new EntityType( "http://purl.imsglobal.org/caliper/v1/Annotation" );
			public static readonly EntityType Attempt = new EntityType( "http://purl.imsglobal.org/caliper/v1/Attempt" );
			public static readonly EntityType CourseOffering = new EntityType( "http://purl.imsglobal.org/caliper/v1/lis/CourseOffering" );
			public static readonly EntityType CourseSection = new EntityType( "http://purl.imsglobal.org/caliper/v1/lis/CourseSection" );
			public static readonly EntityType DigitalResource = new EntityType( "http://purl.imsglobal.org/caliper/v1/DigitalResource" );
			public static readonly EntityType Entity = new EntityType( "http://purl.imsglobal.org/caliper/v1/Entity" );
			public static readonly EntityType Generated = new EntityType( "http://purl.imsglobal.org/caliper/v1/Generated" );
			public static readonly EntityType Group = new EntityType( "http://purl.imsglobal.org/caliper/v1/lis/Group" );
			public static readonly EntityType LearningObjective = new EntityType( "http://purl.imsglobal.org/caliper/v1/LearningObjective" );
			public static readonly EntityType MediaObject = new EntityType( "http://purl.imsglobal.org/caliper/v1/MediaObject" );
			public static readonly EntityType Membership = new EntityType( "http://purl.imsglobal.org/caliper/v1/lis/Membership" );
			public static readonly EntityType Person = new EntityType( "http://purl.imsglobal.org/caliper/v1/lis/Person" );
			public static readonly EntityType Organization = new EntityType( "http://purl.imsglobal.org/caliper/v1/lis/Organization" );
			public static readonly EntityType Response = new EntityType( "http://purl.imsglobal.org/caliper/v1/Response" );
			public static readonly EntityType Result = new EntityType( "http://purl.imsglobal.org/caliper/v1/Result" );
			public static readonly EntityType Session = new EntityType( "http://purl.imsglobal.org/caliper/v1/Session" );
			public static readonly EntityType SoftwareApplication = new EntityType( "http://purl.imsglobal.org/caliper/v1/SoftwareApplication" );
			public static readonly EntityType Target = new EntityType( "http://purl.imsglobal.org/caliper/v1/Target" );
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

		[JsonProperty( "description", Order = 4 )]
		public string Description { get; set; }

		[JsonProperty( "extensions", Order = 51 )]
		public IDictionary<string, string> Extensions { get; set; }

		[JsonProperty( "dateCreated", Order = 52 )]
		public long DateCreated { get; set; }

		[JsonProperty( "dateModified", Order = 53 )]
		public long DateModified { get; set; }

	}

}
