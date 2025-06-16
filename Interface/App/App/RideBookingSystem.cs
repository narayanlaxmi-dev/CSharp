using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class RideBookingSystem
    {
        public void Bookride(IVehicle vehicle, double dist)
        {
            Console.WriteLine($" the details is : {vehicle.GetDetails()}\nThe distance{dist} the FiarPrice {vehicle.CalculateFare(dist)}");
        }
    }
}
