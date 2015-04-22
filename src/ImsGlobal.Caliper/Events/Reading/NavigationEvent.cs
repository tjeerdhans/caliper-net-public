using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Events.Reading {
	using ImsGlobal.Caliper.Events;
	using ImsGlobal.Caliper.Entities;

	/// <summary>
	/// Event raised when an actor navigates from one resource to another.
	/// </summary>
	public class NavigationEvent : Event {

		public NavigationEvent() {
			this.Context = EventContext.Navigation;
			this.Type = EventType.Navigation;
			this.Action = Action.NavigatedTo;
		}

		/// <summary>
		/// The resource from which the navigation starts.
		/// </summary>
		[JsonProperty( "navigatedFrom", Order = 99 )]
		public DigitalResource FromResource { get; set; }

	}

}
