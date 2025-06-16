using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
   
    internal class OperationDelegate
    {
        public  int Add(int a, int b)
        {
            return a + b;
        }

        public  int Sub(int a, int b)
        {
            return a - b;
        }

        public  void ExecutionOperation(int a, int b, Operation op)
        {
            int res = op(a, b);

            Console.WriteLine("Result is : " + res);
        }
    }
}
