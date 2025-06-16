using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? UserEmail { get; set; }
        public string? Password { get; set; }

        // navigation property
        public UserProfile? Profile { get; set; }
    }
    public class UserProfile
    {

        [Key]
        public int UserProfileId { get; set; }
        public string? UserFullName { get; set; }
        public int? Age { get; set; }
        public string? Bio { get; set; }
        // foreign jey navigation property
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
