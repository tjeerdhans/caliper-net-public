﻿using ImsGlobal.Caliper.Entities.Assignable;
using ImsGlobal.Caliper.Entities.Foaf;
using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;
using NodaTime;

namespace ImsGlobal.Caliper.Entities.Response
{
    public class Response : Entity
    {
        public Response(string id)
            : base(id)
        {
            Type = EntityType.Response;
        }

        [JsonProperty("assignable", Order = 11)]
        [JsonConverter(typeof(JsonIdConverter<DigitalResource>))]
        public DigitalResource Assignable { get; set; }

        [JsonProperty("actor", Order = 12)]
        [JsonConverter(typeof(JsonIdConverter<IAgent>))]
        public IAgent Actor { get; set; }

        [JsonProperty("attempt", Order = 13)]
        public Attempt Attempt { get; set; }

        [JsonProperty("startedAtTime", Order = 14)]
        public Instant? StartedAtTime { get; set; }

        [JsonProperty("endedAtTime", Order = 15)]
        public Instant? EndedAtTime { get; set; }

        [JsonProperty("duration", Order = 16)]
        public Period Duration { get; set; }
    }
}