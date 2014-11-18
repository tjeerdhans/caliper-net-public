using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Actions {

	public sealed class ReadingAction {

		public static readonly ReadingAction NavigatedTo = new ReadingAction( "navigation.navigatedTo" );
		public static readonly ReadingAction Viewed = new ReadingAction( "reading.viewed" );
		public static readonly ReadingAction Searched = new ReadingAction( "reading.searched" );

		private ReadingAction( string action ) {
			this.Value = action;
		}

		public string Value { get; private set; }
	}

}

