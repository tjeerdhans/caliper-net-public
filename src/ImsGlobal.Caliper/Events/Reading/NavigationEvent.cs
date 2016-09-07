using ImsGlobal.Caliper.Entities;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Events.Reading
{
    /// <summary>
    /// Event raised when an actor navigates from one resource to another.
    /// </summary>
    public class NavigationEvent : Event
    {
        public NavigationEvent()
        {
            Type = EventType.Navigation;
            Action = Action.NavigatedTo;
        }

        /// <summary>
        /// The resource from which the navigation starts.
        /// </summary>
        [JsonProperty("navigatedFrom", Order = 99)]
        public DigitalResource FromResource { get; set; }
    }
}