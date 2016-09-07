using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Assessment
{
    using Assignable;
    using Qti;

    public class AssessmentItem : AssignableDigitalResource, IAssessmentItem
    {

        public AssessmentItem(string id)
            : base(id)
        {
            Type = AssignableDigitalResourceType.AssessmentItem;
        }

        [JsonProperty("isTimeDependent", Order = 31)]
        public bool IsTimeDependent { get; set; }

    }

}
