﻿using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Events
{
    [JsonConverter(typeof(JsonValueConverter<EventType>))]
    public sealed class EventType : IJsonValue
    {
        public static readonly EventType Annotation = new EventType("http://purl.imsglobal.org/caliper/v1/AnnotationEvent");
        public static readonly EventType Assessment = new EventType("http://purl.imsglobal.org/caliper/v1/AssessmentEvent");
        public static readonly EventType AssessmentItem = new EventType("http://purl.imsglobal.org/caliper/v1/AssessmentItemEvent");
        public static readonly EventType Assignable = new EventType("http://purl.imsglobal.org/caliper/v1/AssignableEvent");
        public static readonly EventType Event = new EventType("http://purl.imsglobal.org/caliper/v1/Event");
        public static readonly EventType Media = new EventType("http://purl.imsglobal.org/caliper/v1/MediaEvent");
        public static readonly EventType Navigation = new EventType("http://purl.imsglobal.org/caliper/v1/NavigationEvent");
        public static readonly EventType Outcome = new EventType("http://purl.imsglobal.org/caliper/v1/OutcomeEvent");
        public static readonly EventType Session = new EventType("http://purl.imsglobal.org/caliper/v1/SessionEvent");
        public static readonly EventType View = new EventType("http://purl.imsglobal.org/caliper/v1/ViewEvent");

        public EventType()
        {
        }

        public EventType(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }
}