namespace ImsGlobal.Caliper.Events.Assessment
{
    /// <summary>
    /// Event raised when an actor interacts with an assessment item resource.
    /// </summary>
    public class AssessmentItemEvent : Event
    {
        public AssessmentItemEvent(Action action)
        {
            Type = EventType.AssessmentItem;
            Action = action;
        }
    }
}