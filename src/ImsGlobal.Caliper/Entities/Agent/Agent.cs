using ImsGlobal.Caliper.Entities.Foaf;

namespace ImsGlobal.Caliper.Entities.Agent
{
    public class Agent : BaseEntity, IAgent
    {
        public Agent(string id)
            : base(id)
        {
        }
    }
}