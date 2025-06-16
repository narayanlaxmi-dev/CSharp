using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal static class BookExtension1
    {
        public static void Bookprint1(this Book a)
        {
            Console.WriteLine($"Title: {a.Title}, Description: {a.Description}, Price: {a.Price}");
        }
    }
}
