using netcore.Domain.Slider;

namespace netcore.Domain.Post
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
    }
}