namespace ImsGlobal.Caliper.Entities
{
    public class WebPage : DigitalResource
    {
        public WebPage(string id)
            : base(id)
        {
            Type = DigitalResourceType.WebPage;
        }
    }
}