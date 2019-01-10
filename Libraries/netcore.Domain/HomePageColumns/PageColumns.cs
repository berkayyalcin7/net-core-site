using netcore.Domain.Slider;

namespace netcore.Domain.HomePageColumns
{
    public class PageColumns : BaseEntity
    {
        public string IconName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PageUrl { get; set; }
    }
}