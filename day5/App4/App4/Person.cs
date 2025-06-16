using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    internal class Person
    {
        private string name = "NaraYana";


        public void DisplayName()
        {
            Console.WriteLine("Name: " + name);
        }


        public Person() { }
        public Person(int age) { }
        public Person(string name) { }
        public Person(string name, int age) { }

      
    }
}
