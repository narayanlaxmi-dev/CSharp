using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal class Vehicle
    {
        public virtual void emissionCehck()
        {
            Console.WriteLine("Default vehicle Check");
        }
    }
    class Bike : Vehicle {
        public override void emissionCehck()
        {
            base.emissionCehck();
            Console.WriteLine("Bike vehicle Check");
        }
    }

    class Truck : Vehicle {
        public override void emissionCehck()
        {
            Console.WriteLine("Truck vehicle Check");
        }
    }
}
