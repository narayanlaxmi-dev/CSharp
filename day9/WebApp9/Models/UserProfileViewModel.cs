using System.ComponentModel.DataAnnotations;

namespace WebApp9.Models
{
    public class UserProfileViewModel
    {
        [Key]
        public int Id { get; set; }
        public string? UserEmail { get; set; }
        public string? Password { get; set; }
        public string? UserFullName { get; set; }
        public string? Bio { get; set; }
        public int? Age { get; set; }
    }
}
