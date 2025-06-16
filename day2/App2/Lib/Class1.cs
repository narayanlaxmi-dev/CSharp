using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Class1
    {
        public int var; // access only project mylib
        internal int internalVar; // acces all project how add reference
        internal protected int internalprotectedVar; // acces all project ow inherated this class and  how add reference

        public void add(ref int i)
        {
            i = 200;
        }

        public void MyLib()
        {
            Console.WriteLine("myLib Lib Reference added, \n" +
                "Yoo");
        }
    }
}
