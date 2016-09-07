using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// Core base class for Caliper entities. Analogous to a schema.org Thing.
    /// </summary>
    public class BaseEntity : IJsonId
    {
        public BaseEntity(string id)
        {
            Id = id;
            Type = EntityType.Entity;
        }

        [JsonProperty("@type", Order = 2)]
        public IType Type { get; set; }

        [JsonProperty("@id", Order = 1)]
        public string Id { get; set; }
    }
}