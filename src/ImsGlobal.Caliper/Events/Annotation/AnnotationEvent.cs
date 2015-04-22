using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Annotation {
	using Annotation = ImsGlobal.Caliper.Entities.Annotation.Annotation;
	using AnnotationType = ImsGlobal.Caliper.Entities.Annotation.Annotation.AnnotationType;

	/// <summary>
	/// Event raised when an actor annotates a resource.
	/// </summary>
	public class AnnotationEvent : Event {

		private static readonly Dictionary<string, Action> _annotationTypeToAction = new Dictionary<string, Action> {
			{ AnnotationType.Bookmark.Uri, Events.Action.Bookmarked },
			{ AnnotationType.Highlight.Uri, Events.Action.Highlighted },
			{ AnnotationType.Share.Uri, Events.Action.Shared },
			{ AnnotationType.Tag.Uri, Events.Action.Tagged }
		};

		public AnnotationEvent( Annotation annotation )
			: base() {

			this.Context = "http://purl.imsglobal.org/ctx/caliper/v1/AnnotationEvent";
			this.Type = "http://purl.imsglobal.org/caliper/v1/AnnotationEvent";
			this.Action = MapAnnotationEntityToAction( annotation );
			this.Object = annotation;
		}

		private Action MapAnnotationEntityToAction( Annotation annotation ) {
			Action action;
			_annotationTypeToAction.TryGetValue( annotation.Type, out action );
			return action;
		}

	}

}
