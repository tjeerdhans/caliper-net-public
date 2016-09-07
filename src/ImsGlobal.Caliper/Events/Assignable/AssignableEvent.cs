namespace ImsGlobal.Caliper.Events.Assignable
{
    /// <summary>
    /// Event raised when an actor interacts with an assignable resource.
    /// </summary>
    public class AssignableEvent : Event
    {
        public AssignableEvent(Action action)
        {
            Type = EventType.Assignable;
            Action = action;
        }
    }
}