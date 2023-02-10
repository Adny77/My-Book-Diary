namespace MyBookDiary.Core
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string Biography { get; set; } = null!;

        public ICollection<Book> Books { get; set; } = null!;
    }
}
