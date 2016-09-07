using ImsGlobal.Caliper.Entities.Foaf;

namespace ImsGlobal.Caliper.Entities.Agent
{
    public class Person : Entity, IAgent
    {
        public Person(string id)
            : base(id)
        {
            Type = EntityType.Person;
        }
    }
}