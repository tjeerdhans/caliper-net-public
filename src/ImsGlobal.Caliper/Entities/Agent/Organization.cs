using ImsGlobal.Caliper.Entities.Foaf;
using ImsGlobal.Caliper.Entities.W3c;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Agent
{
    /// <summary>
    /// A collection of people organized together into a community or other
    /// social, commercial or political structure. The group has some common
    /// purpose or reason for existence which goes beyond the set of people
    /// belonging to it and can act as an Agent. Organizations are often
    /// decomposable into hierarchical structures.
    /// </summary>
    public class Organization : Entity, IAgent, IOrganization
    {
        public Organization(string id)
            : base(id)
        {
            Type = EntityType.Organization;
        }

        [JsonProperty("subOrganizationOf", Order = 12)]
        public IOrganization SubOrganizationOf { get; set; }
    }
}