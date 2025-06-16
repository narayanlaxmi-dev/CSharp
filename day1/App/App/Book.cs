using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Book
    {
        public int id;
        public string name;
        public string title;
        public string description;

        public Book() { }


        public Book(int id, string name, string title, string description)
        {
            this.id = id;
            this.name = name;
            this.title = title;
            this.description = description;
        }

        public Book(Book b1) {
            id = b1.id;
            name = b1.name;
            title = b1.title;
            description = b1.description;

        }
        public void show()
        {
            Console.WriteLine($"{id} , {name}, {title}, {description}");
        }
    }
}
