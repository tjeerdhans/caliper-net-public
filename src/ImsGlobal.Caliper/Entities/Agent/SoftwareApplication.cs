using ImsGlobal.Caliper.Entities.Foaf;
using ImsGlobal.Caliper.Entities.SchemaDotOrg;

namespace ImsGlobal.Caliper.Entities.Agent
{
    public class SoftwareApplication : Entity, IAgent, ISoftwareApplication
    {
        public SoftwareApplication(string id)
            : base(id)
        {
            Type = EntityType.SoftwareApplication;
        }
    }
}