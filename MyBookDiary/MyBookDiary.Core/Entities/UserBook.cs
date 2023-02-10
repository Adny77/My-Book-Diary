
namespace MyBookDiary.Core
{
    public class UserBook : BaseEntity
    {
        public float? Rating { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int BookId { get; set; }
        public Book Book { get; set; } = null!;
    }
}
