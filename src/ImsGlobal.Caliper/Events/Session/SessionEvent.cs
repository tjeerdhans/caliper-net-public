namespace ImsGlobal.Caliper.Events.Session
{
    public class SessionEvent : Event
    {
        public SessionEvent(Action action)
        {
            Type = EventType.Session;
            Action = action;
        }
    }
}