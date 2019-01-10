using netcore.Domain.Slider;

namespace netcore.Domain.GeneralSettings
{
    public class GeneralSettings : BaseEntity
    {
        public string SiteTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string LogoUrl { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string LinkedIn { get; set; }
        public string GoogleAnalytics { get; set; }
        public string GoogleMaps { get; set; }
    }
}