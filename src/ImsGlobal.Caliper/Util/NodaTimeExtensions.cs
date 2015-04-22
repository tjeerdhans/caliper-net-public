using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NodaTime;
using NodaTime.Text;

namespace ImsGlobal.Caliper.Util {

	static class NodaTimeExtensions {

		public static string ToXsdDuration( this Period period ) {
			PeriodPattern pattern = PeriodPattern.RoundtripPattern;
			return pattern.Format( period );
		}

	}

}
