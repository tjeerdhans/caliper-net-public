using ImsGlobal.Caliper.Util;

namespace ImsGlobal.Caliper.Entities.Foaf
{
    /// <summary>
    /// An entity that can do things. Typical kinds of agents include people,
    /// organizations and software systems.
    /// See http://xmlns.com/foaf/spec/#term_Agent
    /// </summary>
    public interface IAgent : IJsonId
    {
        IType Type { get; set; }
    }
}