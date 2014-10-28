using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Lis {

	public class LisPerson : CaliperEntity, ICaliperAgent {

		private const string TYPE_URI = "http://purl.imsglobal.org/caliper/v1/LISPerson";

		public LisPerson( string id )
			: base() {

			this.Type = TYPE_URI;
			this.Id = id;
		}

	}

}
