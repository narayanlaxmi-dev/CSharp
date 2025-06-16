using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal class Company
    {
        public void DisplayPolicy()
        {
            Console.WriteLine("DEFAULT : company Policy");
        }
    }
    class ContractDept : Company
    {

        public new void DisplayPolicy()
        {
            Console.WriteLine(" company Policy for employee e1");
            
        }
    }

    class accessMylib : Class1
    {
        public accessMylib()
        {
            internalprotectedVar = 90;
            Console.WriteLine(internalprotectedVar);
        }
    }
   
}
