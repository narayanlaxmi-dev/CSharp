using System.ComponentModel.DataAnnotations;

namespace EFDemo.Models
{
    public class UserProfile1_1
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public virtual User? User { get; set; }


        public int UserProfileId { get; set; }
        public virtual UserProfile? UserProfile { get; set; }
    }
}
