using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities {

	/// <summary>
	/// Represents the context of an activity, e.g. an assignment.
	/// </summary>
	public class ActivityContext : Entity {

		public ActivityContext( string id )
			: base( id ) {
			this.Type = EntityType.ActivityContext.Uri;
		}

	}

}
