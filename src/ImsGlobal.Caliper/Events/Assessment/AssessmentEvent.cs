namespace ImsGlobal.Caliper.Events.Assessment
{
    /// <summary>
    /// Event raised when an actor interacts with an assessment resource.
    /// </summary>
    public class AssessmentEvent : Event
    {
        public AssessmentEvent(Action action)
        {
            Type = EventType.Assessment;
            Action = action;
        }
    }
}