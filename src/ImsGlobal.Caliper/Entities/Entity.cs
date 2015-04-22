using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities {
	using ImsGlobal.Caliper.Util;

	/// <summary>
	/// The base Caliper Entity. Analogous to a schema.org Thing.
	/// </summary>
	public class Entity : IJsonId {

		public Entity( string id ) {
			this.Id = id;
			this.Type = EntityType.Entity;
			this.Extensions = new Dictionary<string, string>();
		}

		[JsonProperty( "@id", Order = 1 )]
		public string Id { get; set; }

		[JsonProperty( "@type", Order = 2 )]
		public IType Type { get; set; }

		[JsonProperty( "name", Order = 3 )]
		public string Name { get; set; }

		[JsonProperty( "description", Order = 4 )]
		public string Description { get; set; }

		[JsonProperty( "extensions", Order = 51 )]
		public IDictionary<string, string> Extensions { get; set; }

		[JsonProperty( "dateCreated", Order = 52 )]
		public DateTime? DateCreated { get; set; }

		[JsonProperty( "dateModified", Order = 53 )]
		public DateTime? DateModified { get; set; }

	}

}
