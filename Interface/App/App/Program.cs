using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RideBookingSystem system = new RideBookingSystem();

            IVehicle car= new Car();
            IVehicle bike = new Bike();
            IVehicle scooter = new Scooter();

            system.Bookride(car,20);
            Console.WriteLine("-----------------");
            system.Bookride(bike, 20);
            Console.WriteLine("-----------------");
            system.Bookride(scooter, 10);


        }
    }
}
