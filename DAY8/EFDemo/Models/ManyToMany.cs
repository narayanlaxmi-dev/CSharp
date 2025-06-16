using System.ComponentModel.DataAnnotations;

namespace EFDemo.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Author>? Author { get; set; }
    }
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string? FullName { get; set; }

        public virtual ICollection<Book>? Books { get; set; }
    }
}
