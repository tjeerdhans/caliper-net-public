using System.Collections.Generic;
using ImsGlobal.Caliper.Entities.SchemaDotOrg;
using Newtonsoft.Json;
using NodaTime;

namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// Caliper representation of a CreativeWork (https://schema.org/CreativeWork)
    /// </summary>
    public class DigitalResource : Entity, ICreativeWork
    {
        public DigitalResource(string id)
            : base(id)
        {
            Type = EntityType.DigitalResource;
            ObjectTypes = new List<string>();
            AlignedLearningObjectives = new List<LearningObjective>();
            Keywords = new List<string>();
        }

        /// <summary>
        /// The object type of the resource.
        /// </summary>
        [JsonProperty("objectType", Order = 11)]
        public IList<string> ObjectTypes { get; set; }

        /// <summary>
        /// List of learning objectives aligned with this resource.
        /// </summary>
        [JsonProperty("alignedLearningObjective", Order = 12)]
        public IList<LearningObjective> AlignedLearningObjectives { get; set; }

        /// <summary>
        /// List of keywords that describe this resource.
        /// </summary>
        [JsonProperty("keywords", Order = 13)]
        public IList<string> Keywords { get; set; }

        /// <summary>
        /// A reference to the parent resource, if any.
        /// </summary>
        [JsonProperty("isPartOf", Order = 61)]
        public ICreativeWork IsPartOf { get; set; }

        /// <summary>
        /// The date the digital resource was published.
        /// </summary>
        [JsonProperty("datePublished", Order = 62)]
        public Instant? DatePublished { get; set; }

        /// <summary>
        /// The current version of the digital resource.
        /// </summary>
        [JsonProperty("version", Order = 63)]
        public string Version { get; set; }
    }
}