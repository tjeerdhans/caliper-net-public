namespace ImsGlobal.Caliper.Entities.Assessment
{
    using Assignable;
    using Qti;

    public class Assessment : AssignableDigitalResource, IAssessment
    {

        public Assessment(string id)
            : base(id)
        {
            Type = AssignableDigitalResourceType.Assessment;
        }

    }

}
