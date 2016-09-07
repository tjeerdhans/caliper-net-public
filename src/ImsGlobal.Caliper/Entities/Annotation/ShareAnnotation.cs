using System.Collections.Generic;
using ImsGlobal.Caliper.Entities.Foaf;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Annotation
{
    public class ShareAnnotation : Annotation
    {
        public ShareAnnotation(string id)
            : base(id)
        {
            Type = AnnotationType.Share;
            WithAgents = new List<IAgent>();
        }

        [JsonProperty("withAgents", Order = 31)]
        public IList<IAgent> WithAgents { get; set; }
    }
}