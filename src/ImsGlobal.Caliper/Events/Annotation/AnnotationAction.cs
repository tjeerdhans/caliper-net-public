using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Annotation {

	public sealed class AnnotationAction {

		public static readonly AnnotationAction Attached = new AnnotationAction( "attached" );
		public static readonly AnnotationAction Bookmarked = new AnnotationAction( "bookmarked" );
		public static readonly AnnotationAction Classified = new AnnotationAction( "classified" );
		public static readonly AnnotationAction Commented = new AnnotationAction( "commented" );
		public static readonly AnnotationAction Described = new AnnotationAction( "described" );
		public static readonly AnnotationAction Highlighted = new AnnotationAction( "highlighted" );
		public static readonly AnnotationAction Identified = new AnnotationAction( "identified" );
		public static readonly AnnotationAction Liked = new AnnotationAction( "liked" );
		public static readonly AnnotationAction Linked = new AnnotationAction( "linked" );
		public static readonly AnnotationAction Ranked = new AnnotationAction( "ranked" );
		public static readonly AnnotationAction Questioned = new AnnotationAction( "questioned" );
		public static readonly AnnotationAction Recommended = new AnnotationAction( "recommended" );
		public static readonly AnnotationAction Replied = new AnnotationAction( "replied" );
		public static readonly AnnotationAction Shared = new AnnotationAction( "shared" );
		public static readonly AnnotationAction Subscribed = new AnnotationAction( "subscribed" );
		public static readonly AnnotationAction Tagged = new AnnotationAction( "tagged" );

		private AnnotationAction( string action ) {
			this.Value = action;
		}

		public string Value { get; private set; }
	}

}

