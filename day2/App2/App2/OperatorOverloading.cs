using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal class OperatorOverloading
    {
        private int Real;
        private int Complex;
        public OperatorOverloading() { }
        public OperatorOverloading(int Real, int Complex)
        {
            this.Real = Real;
            this.Complex = Complex;
        }
        public static OperatorOverloading operator +(OperatorOverloading a, OperatorOverloading b)
        {
            return new OperatorOverloading(a.Real + b.Real, a.Complex + b.Complex);
        }

        public override string ToString()
        {
            return $"{Real + Complex}";
        }

        public void print()
        {
            Console.WriteLine(Real);
            Console.WriteLine(Complex);
        }
    }
}
