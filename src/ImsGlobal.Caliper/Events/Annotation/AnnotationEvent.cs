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
			{ AnnotationType.Bookmark.Uri, Action.Bookmarked },
			{ AnnotationType.Highlight.Uri, Action.Highlighted },
			{ AnnotationType.Share.Uri, Action.Shared },
			{ AnnotationType.Tag.Uri, Action.Tagged }
		};

		public AnnotationEvent( Annotation annotation ) {

			this.Context = EventContext.Annotation;
			this.Type = EventType.Annotation;
			this.Action = MapAnnotationEntityToAction( annotation );
			this.Object = annotation;
		}

		private static Action MapAnnotationEntityToAction( Annotation annotation ) {
			Action action;
			_annotationTypeToAction.TryGetValue( annotation.Type, out action );
			return action;
		}

	}

}
