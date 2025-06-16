namespace E_commerce_exercise.Models
{
    public class Deal
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public double Discount { get; set; }
        public bool isActive { get; set; }
    }
}
