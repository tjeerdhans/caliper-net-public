using ImsGlobal.Caliper.Entities.W3c;

namespace ImsGlobal.Caliper.Entities.Lis
{
    /// <summary>
    /// The course interface marks an object type that represents an LIS
    /// Course. The interface allows Caliper to catch errors at compile
    /// time for instances of the marked class rather than at runtime if
    /// a marker annotation was defined instead.
    /// </summary>
    public interface ICourse : IOrganization
    {
    }
}