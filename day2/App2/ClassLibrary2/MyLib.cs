using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    //C# window library class lib .net framework goto main project reference and add
    public class MyLib
    {
        public static void MyLibFunctionStatic() { Console.WriteLine("ADDED EXTERNAL LIBRARY REFERENCE"); }
        public  void MyLibFunctionNonSatic() { Console.WriteLine("ADDED EXTERNAL LIBRARY REFERENCE"); }
    }
}
