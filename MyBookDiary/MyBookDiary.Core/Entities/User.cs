using System.Security.Principal;

namespace MyBookDiary.Core
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; } 
        public string PasswordSalt { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public Role Role { get; set; }


    }
}
