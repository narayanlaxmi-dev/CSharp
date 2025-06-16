using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Bike : IVehicle
    {
        public double CalculateFare(double distance)
        {
            return distance * 10; // per km
        }

        public string GetDetails()
        {
            return $" Bike, 2-wheeler, Petrol ";
        }
    }
}
