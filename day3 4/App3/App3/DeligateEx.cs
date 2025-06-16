using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    internal class DeligateEx
    {
        public void ShowDetails()
        {
            Console.WriteLine("HelloDelegateEx Class");
        }
        public void ShowDetails(int a)
        {
            Console.WriteLine($"HelloDelegateEx Class{a}");
        }


    }
}
