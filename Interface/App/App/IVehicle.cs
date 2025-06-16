using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal interface IVehicle
    {
         double CalculateFare(double distance);
        String GetDetails();
    }
}
