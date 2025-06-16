using System;

namespace CSharpMiniProjects
{
    public class Product
    {
        private string Name;
        private double Price;

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product(Product other)
        {
            Name = other.Name;
            Price = other.Price;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}");
        }
    }
}