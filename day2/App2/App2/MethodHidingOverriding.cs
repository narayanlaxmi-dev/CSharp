using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal class MethodHidingOverriding
    {
        public void Show()
        {
            Console.WriteLine("Base method ");
        }
        public virtual void Show1()
        {
            Console.WriteLine(" Virtual Base method ");
        }
    }

    internal class MethodHiding : MethodHidingOverriding
    {
        public new void Show() // new use dont use doesnt matter
        {
            Console.WriteLine("MethodHiding method,Created new method not used in baseClass  ");
        }

    }

    internal class Overriding : MethodHidingOverriding
    {
        public override void Show1() // if i dont add override or virtual then only baseClass method called not derived class
        {
            Console.WriteLine("Overridden Show1 method called");
        }
    }
}
