using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Media {

	public sealed class MediaAction {

		public static readonly MediaAction DisabledClosedCaptioning = new MediaAction( "disabled closed captioning" );
		public static readonly MediaAction EnabledClosedCaptioning = new MediaAction( "enabled closed captioning" );
		public static readonly MediaAction ChangedVolume = new MediaAction( "changed volume" );
		public static readonly MediaAction Muted = new MediaAction( "muted" );
		public static readonly MediaAction Unmuted = new MediaAction( "unmuted" );
		public static readonly MediaAction ChangedSpeed = new MediaAction( "changed speed" );
		public static readonly MediaAction Ended = new MediaAction( "ended" );
		public static readonly MediaAction ForwardedTo = new MediaAction( "forwarded to" );
		public static readonly MediaAction JumpedTo = new MediaAction( "jumped to" );
		public static readonly MediaAction Paused = new MediaAction( "paused" );
		public static readonly MediaAction Resumed = new MediaAction( "resumed" );
		public static readonly MediaAction RewindedTo = new MediaAction( "rewinded to" );
		public static readonly MediaAction Started = new MediaAction( "started" );
		public static readonly MediaAction ChangedResolution = new MediaAction( "changed resolution" );
		public static readonly MediaAction ChangedViewerSize = new MediaAction( "changed viewer size" );
		public static readonly MediaAction EnteredFullScreen = new MediaAction( "entered full screen" );
		public static readonly MediaAction OpenedPopout = new MediaAction( "opened popout" );
		public static readonly MediaAction ExitedFullScreen = new MediaAction( "exited full screen" );
		public static readonly MediaAction ClosedPopout = new MediaAction( "closed popout" );

		private MediaAction( string action ) {
			this.Value = action;
		}

		public string Value { get; private set; }

	}

}

