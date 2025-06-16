using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }

        // navigation property
        public virtual UserProfile? profile { get; set; }
    }
    public class UserProfile
    {
        [Key]
        public int UserProfileId { get; set; }
        public string? Bio { get; set; }
        // foreign jey navigation property
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public virtual User? user { get; set; }
    }
}
