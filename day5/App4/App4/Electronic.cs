using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    using System;

    public class Electronic
    {
        public int Lid { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public Electronic(int lid, string brand, string model, double price)
        {
            Lid = lid;
            Brand = brand;
            Model = model;
            Price = price;
        }

        public string Display()
        {
            return $"ID:{Lid} Brand: {Brand}, Model: {Model}, Price: ${Price}";
        }
    }

    public class Manager<T> where T : Electronic
    {
        private T item;

        // Add item
        public void AddItem(T newItem)
        {
            item = newItem;
            Console.WriteLine("Item added.");
        }

        // Remove item
        public void RemoveItem(int id)
        {
            if (item == null)
            {
                Console.WriteLine("No item to remove.");
            }
            else
            {
                if (item.Lid == id)
                {
                    item = default(T);
                    Console.WriteLine("Item removed.");
                }
            }
        }

        // Display item using a delegate
        public void PrintItem(Func<T, string> displayFunc)
        {
            if (item == null)
            {
                Console.WriteLine("No item to display.");
            }
            else
            {
                Console.WriteLine(displayFunc(item));
            }
        }
    }

}
