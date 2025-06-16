using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    internal class TaxService
    {
        public TaxDelegate taxLogic;
        public TaxService() { }

        public TaxService(TaxDelegate logic) // constructor or i delcare in method 
        {
            taxLogic = logic;
        }
        public void PrintTax(IVehicle v)
        {
            double tax = taxLogic(v); // taxLogic is delegate we call to dynamic func
            Console.WriteLine($"price : {v.Price} |  type : {v.Type} | Calc Tax : {tax}");
        }

        // also valid without Constructor
 
        public void PrintTax(IVehicle v, TaxDelegate taxLogic)
        {
            double tax = taxLogic(v);
            Console.WriteLine($"price : {v.Price} |  type : {v.Type} | Calc Tax : {tax}");
        }

    }
}