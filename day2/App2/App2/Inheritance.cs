using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal class Inheritance
    {
        public virtual void talk() =>
            Console.WriteLine("Talking to Animal");

    }

    class Dog : Inheritance
    {
        public override void talk() => Console.WriteLine("Bark.");

    }
    class Cat : Inheritance
    {
        public override void talk() => Console.WriteLine("Meow.");

    }

    class Lion : Inheritance
    {
        public override void talk() => Console.WriteLine("Roar.");

    }
}
