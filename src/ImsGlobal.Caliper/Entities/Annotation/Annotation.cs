﻿using ImsGlobal.Caliper.Entities.SchemaDotOrg;
using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Annotation
{
    /// <summary>
    /// Base type for all annotation types. Direct sub-types, such as
    /// Highlight, Attachment, etc, are specified in the Caliper
    /// Annotation Metric Profile.
    /// </summary>
    public class Annotation : Entity, IThing
    {
        public Annotation(string id)
            : base(id)
        {
            Type = EntityType.Annotation;
        }

        [JsonProperty("annotated", Order = 21)]
        [JsonConverter(typeof(JsonIdConverter<DigitalResource>))]
        public DigitalResource Annotated { get; set; }
    }
}