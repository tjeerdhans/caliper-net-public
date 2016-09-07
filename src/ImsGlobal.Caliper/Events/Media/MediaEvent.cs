namespace ImsGlobal.Caliper.Events.Media
{
    /// <summary>
    /// Event raised when an actor interacts with a media resource.
    /// </summary>
    public class MediaEvent : Event
    {
        public MediaEvent(Action action)
        {
            Type = EventType.Media;
            Action = action;
        }
    }
}