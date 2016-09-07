using ImsGlobal.Caliper.Entities.SchemaDotOrg;

namespace ImsGlobal.Caliper.Entities.Media
{
    /// <summary>
    /// A video object embedded in a web page.
    /// </summary>
    public class VideoObject : MediaObject, IVideoObject
    {
        public VideoObject(string id)
            : base(id, MediaObjectType.VideoObject)
        {
        }
    }
}