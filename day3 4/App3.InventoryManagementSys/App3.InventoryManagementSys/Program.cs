using App3.InventoryManagementSys.App3.InventoryManagementSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.InventoryManagementSys
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[] {
            new Product{ Name="laptop", Price=1200,CountStock=50, Category="Electornic"},
               new Product{ Name="Rubber", Price=10,CountStock=1, Category="Stationery"},
            };

            Console.WriteLine("Product");
            DelegateLogic.Calc(products, p => p.Price >100); // or 
            //bool PriceGreaterThan100(Product p)
            //{
            //    return p.Price > 100;
            //}
            //DelegateLogic.Calc(products, PriceGreaterThan100);

            DelegateLogic.Calc(products, p => p.CountStock < 10);

            DelegateLogic.Calc(products,p=> p.Category == "Electornic");




        }
    }
}
