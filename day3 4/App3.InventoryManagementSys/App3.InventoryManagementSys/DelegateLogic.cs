using App3.InventoryManagementSys.App3.InventoryManagementSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.InventoryManagementSys
{
    internal class DelegateLogic
    {
        public static void Calc(Product[] products, Predicate<Product> cond)
        {
            for (int i = 0; i < products.Length; i++) {
                if (cond(products[i])) { 
                products[i].ToString();
                Console.WriteLine(products[i]);

                }
            }
        }
    }
}
