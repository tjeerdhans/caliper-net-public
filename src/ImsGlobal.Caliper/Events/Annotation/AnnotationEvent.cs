using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Events.Annotation {
	using ImsGlobal.Caliper.Entities;
	using ImsGlobal.Caliper.Entities.Annotation;
	using Annotation = ImsGlobal.Caliper.Entities.Annotation.Annotation;

	/// <summary>
	/// Event raised when an actor annotates a resource.
	/// </summary>
	public class AnnotationEvent : Event {

		private static readonly Dictionary<IType, Action> _annotationTypeToAction = new Dictionary<IType, Action> {
			{ AnnotationType.Bookmark, Action.Bookmarked },
			{ AnnotationType.Highlight, Action.Highlighted },
			{ AnnotationType.Share, Action.Shared },
			{ AnnotationType.Tag, Action.Tagged }
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
