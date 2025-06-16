using Microsoft.AspNetCore.Mvc;

namespace Exercise.Models
{
    public class Product 
    {
        public int productId { get; set; }
        public string? productName { get; set; }
        public string? productCategory { get; set; }
        public decimal price { get; set; }
    }
}
