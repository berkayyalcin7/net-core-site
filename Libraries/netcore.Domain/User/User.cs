using netcore.Domain.Slider;

namespace netcore.Domain.User
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ProfileImage { get; set; }
        public string UserBio { get; set; }

    }
}