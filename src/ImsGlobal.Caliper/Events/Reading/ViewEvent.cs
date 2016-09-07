namespace ImsGlobal.Caliper.Events.Reading
{
    /// <summary>
    /// Event raised when an actor views a resource.
    /// </summary>
    public class ViewEvent : Event
    {
        public ViewEvent()
        {
            Type = EventType.View;
            Action = Action.Viewed;
        }
    }
}