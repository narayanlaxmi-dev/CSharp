namespace WebApp9.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarHorsePower { get; set; }
        public string CarEngine { get; set; }
        public string CarColour { get; set; }
        public double Price { get; set; }

        // Foreign key property:
        public int CarShowRoomId { get; set; }

        // Navigation property to showroom
        public CarShowRoom Carshowroom { get; set; }

    }

    public class CarShowRoom
    {
        public int Id { get; set; }
      
        public string ModelType { get; set; }
        public string BrandName { get; set; }
        public string FuelType { get; set; }

        // Navigation property - showroom has many cars
        public ICollection<Car> Car { get; set; }
    }
}
