using netcore.Domain.Slider;

namespace netcore.Domain.Testimonials
{
    public class Testimonials : BaseEntity
    {
        public string ProfileImage { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }

        public string WebSite { get; set; }

    }
}