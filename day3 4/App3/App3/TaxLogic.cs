using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    internal class TaxLogic
    {
        public static double CalcCarTax(IVehicle v) // 
        {
            return v.Price *.9;
        }

        public static double CalcBikeTax(IVehicle v)
        {
            return v.Price * .4;
        }

        public static double CalcScootyTax(IVehicle v)
        {
            return v.Price * .2;
        }
    }
}
