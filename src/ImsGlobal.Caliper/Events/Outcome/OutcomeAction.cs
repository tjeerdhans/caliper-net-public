using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Outcome {

	public sealed class OutcomeAction {

		public static readonly OutcomeAction Graded = new OutcomeAction( "graded" );

		private OutcomeAction( string action ) {
			this.Value = action;
		}

		public string Value { get; private set; }

	}

}

