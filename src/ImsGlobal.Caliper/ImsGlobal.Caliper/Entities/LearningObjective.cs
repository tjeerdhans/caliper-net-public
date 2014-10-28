using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities {

	/// <summary>
	/// Represents a learning objective.
	/// </summary>
	public class LearningObjective : CaliperEntity {

		public LearningObjective(string id) {
			this.Id = id;
			this.Type = "http://purl.imsglobal.org/caliper/v1/LearningObjective";
		}

	}

}
