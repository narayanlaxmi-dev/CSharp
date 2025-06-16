using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFDemo.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string? Title { get; set; }

        // Navigation 1 to many so use collection
        public virtual ICollection<Post>? Posts { get; set; }

    }
    public class Post {
        [Key]
        public int Post_id { get; set; }
        public string? BlogPost { get; set; }
        // foreign jey navigation property
        [ForeignKey("PostId_Blog")]
        public int PostId_Blog { get; set; }
        public virtual Blog? Blog { get; set; }
    }

}
