using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Events.Reading {
	using ImsGlobal.Caliper.Entities;

	/// <summary>
	/// Event raised when an actor navigates from one resource to another.
	/// </summary>
	public class NavigationEvent : CaliperEvent {

		public NavigationEvent()
			: base() {

			this.Context = "http://purl.imsglobal.org/ctx/caliper/v1/NavigationEvent";
			this.Type = "http://purl.imsglobal.org/caliper/v1/NavigationEvent";
			this.Action = "navigatedTo";
		}

		/// <summary>
		/// The resource from which the navigation starts.
		/// </summary>
		[JsonProperty( "navigatedFrom", Order = 99 )]
		public CaliperDigitalResource FromResource { get; set; }

	}

}
