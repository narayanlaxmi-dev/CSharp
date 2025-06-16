using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Car : IVehicle
    {
        public double CalculateFare(double distance)
        {
            return distance * 100; // per km
        }

        public string GetDetails()
        {
            return $" Car, 4-wheeler, Petrol ";
        }
    }
}
