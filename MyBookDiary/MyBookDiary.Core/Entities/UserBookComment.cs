namespace MyBookDiary.Core
{
    public class UserBookComment : BaseEntity
    {
        public string Comment { get; set; } = null!;
        
        public int UserBookId { get; set; }
        public UserBook UserBook { get; set; } = null!;
    }
}
