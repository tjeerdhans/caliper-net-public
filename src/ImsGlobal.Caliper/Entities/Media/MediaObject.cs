using ImsGlobal.Caliper.Entities.SchemaDotOrg;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Media
{
    public class MediaObject : DigitalResource, IMediaObject
    {
        public MediaObject(string id)
            : base(id)
        {
            Type = DigitalResourceType.MediaObject;
        }

        public MediaObject(string id, MediaObjectType type)
            : base(id)
        {
            Type = type;
        }

        [JsonProperty("duration", Order = 71)]
        public long Duration { get; set; }
    }
}