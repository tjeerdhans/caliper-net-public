using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Reading
{
    public class Frame : DigitalResource
    {
        public Frame(string id)
            : base(id)
        {
            Type = DigitalResourceType.Frame;
        }

        [JsonIgnore]
        public Reading Reading { get; set; }

        /// <summary>
        /// Numeric index of the location relative to sibling locations in the content.
        /// </summary>
        [JsonProperty("index", Order = 21)]
        public int Index { get; set; }
    }
}