namespace ImsGlobal.Caliper.Events.Outcome
{
    /// <summary>
    /// Event raised when actions related to an outcome are performed.
    /// </summary>
    public class OutcomeEvent : Event
    {
        public OutcomeEvent(Action action)
        {
            Type = EventType.Outcome;
            Action = action;
        }
    }
}