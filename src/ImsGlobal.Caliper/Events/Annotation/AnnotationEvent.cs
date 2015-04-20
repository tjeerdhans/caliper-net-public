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

		private static readonly Dictionary<string, string> _annotationTypeToAction = new Dictionary<string, string> {
			{ AnnotationType.Bookmark.Uri, Events.Action.Bookmarked.Value },
			{ AnnotationType.Highlight.Uri, Events.Action.Highlighted.Value },
			{ AnnotationType.Share.Uri, Events.Action.Shared.Value },
			{ AnnotationType.Tag.Uri, Events.Action.Tagged.Value }
		};

		public AnnotationEvent( Annotation annotation )
			: base() {

			this.Context = "http://purl.imsglobal.org/ctx/caliper/v1/AnnotationEvent";
			this.Type = "http://purl.imsglobal.org/caliper/v1/AnnotationEvent";
			this.Action = MapAnnotationEntityToAction( annotation );
			this.Object = annotation;
		}

		private string MapAnnotationEntityToAction( Annotation annotation ) {
			string action = null;
			_annotationTypeToAction.TryGetValue( annotation.Type, out action );
			return action;
		}

	}

}
