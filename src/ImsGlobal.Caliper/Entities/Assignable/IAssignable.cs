using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Assignable {

	public interface IAssignable {

		DateTime? DateToActivate { get; }
		DateTime? DateToShow { get; }
		DateTime? DateToStartOn { get; }
		DateTime? DateToSubmit { get; }
		int MaxAttempts { get; }
		int MaxSubmits { get; }

	}

}
