namespace MyBookDiary.Core
{
    public class Book : BaseEntity
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;

    }
}
