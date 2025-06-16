using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal static class ExtensionMethod
    {
        public static void DemoStudent(this Student std)
        {
            Console.WriteLine("Hello to all Students");
        }
    }
}
