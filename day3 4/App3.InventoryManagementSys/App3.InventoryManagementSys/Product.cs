using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App3.InventoryManagementSys
{
    namespace App3.InventoryManagementSys
    {
        class Product 
        {
            public string Name { get; set; }
            public string Category { get; set; } = " Electronic";
            public int CountStock { get; set; }
            public double Price { get; set; }

            public override string ToString()
            {
                return $" Name{Name} | Catagory {Category} | Stock {CountStock} | Price {Price}";
            }
        }
    }

}
