using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Assignable {

	public interface IAssignable {

		long DateCreated { get; }
		long DatePublished { get; }
		long DateToStartOn { get; }
		long DateToActivate { get; }
		long DateToShow { get; }
		long DateToSubmit { get; }
		int MaxAttempts { get; }
		int MaxSubmits { get; }

	}

}
