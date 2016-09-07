using System.Collections.Generic;
using ImsGlobal.Caliper.Entities;
using ImsGlobal.Caliper.Entities.Annotation;

namespace ImsGlobal.Caliper.Events.Annotation
{
    /// <summary>
    /// Event raised when an actor annotates a resource.
    /// </summary>
    public class AnnotationEvent : Event
    {
        private static readonly Dictionary<IType, Action> AnnotationTypeToAction = new Dictionary<IType, Action>
        {
            {AnnotationType.Bookmark, Action.Bookmarked},
            {AnnotationType.Highlight, Action.Highlighted},
            {AnnotationType.Share, Action.Shared},
            {AnnotationType.Tag, Action.Tagged}
        };

        public AnnotationEvent(Entities.Annotation.Annotation annotation)
        {
            Type = EventType.Annotation;
            Action = MapAnnotationEntityToAction(annotation);
            Generated = annotation;
        }

        private static Action MapAnnotationEntityToAction(Entities.Annotation.Annotation annotation)
        {
            Action action;
            AnnotationTypeToAction.TryGetValue(annotation.Type, out action);
            return action;
        }
    }
}