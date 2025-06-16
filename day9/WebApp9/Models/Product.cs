using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp9.Models
{
    public class Product
    {
        // Primary key (non-identity)
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // explicitly not using identity
        public int OrderID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConformPassword { get; set; }

        public string Description { get; set; }

        [Range(-10, 100)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$")]
        public string RegularExpContailAll { get; set; }
    }
}
