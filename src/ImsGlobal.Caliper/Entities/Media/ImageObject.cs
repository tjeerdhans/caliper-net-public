using ImsGlobal.Caliper.Entities.SchemaDotOrg;

namespace ImsGlobal.Caliper.Entities.Media
{
    /// <summary>
    /// An image object embedded in a web page.
    /// </summary>
    public class ImageObject : MediaObject, IImageObject
    {
        public ImageObject(string id)
            : base(id, MediaObjectType.ImageObject)
        {
        }
    }
}