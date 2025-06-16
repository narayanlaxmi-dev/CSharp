using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Scooter : IVehicle
    {
        public double CalculateFare(double distance)
        {
            return distance * 5;
        }

        public string GetDetails()
        {
            return $" Scooter, 2-wheeler, Electric ";
        }
    }
}
