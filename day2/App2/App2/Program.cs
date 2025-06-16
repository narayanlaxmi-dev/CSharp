using ClassLibrary2;
using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal class Program
    {

        static void Main(string[] args)
        {

            /*
            Book book = new Book();
            book.Title = "Meditation";
            book.Description = "Art of war";
            book.Price = 100;   
            book.Bookprint1();  */

            /*
            int[] arr = { 1, 1, 3,2,1};
            int[] arr1 = { 1, 1, 3,4 };
               int[] arr = { 1, 11, 121, 123, 7 };
            foreach (int num in arr)
            {
                if (ArrayPractice.palin(num))
                    Console.WriteLine($"{num} is a palindrome");              
                else              
                    Console.WriteLine($"{num} is not a palindrome");          
            }
            RunMyAllProg.AlreadySorted(arr1);
            RunMyAllProg.countUnique(arr);
            RunMyAllProg.FindMissingAndDuplicate(arr1);
            RunMyAllProg.maxMin(arr);
            RunMyAllProg.palindromeNum(arr);
            RunMyAllProg.reverseArr(arr1);
            RunMyAllProg.secondLargest(arr1);   */

            //RunMyAllProg.IndexcerCall();
            //RunMyAllProg.InheritanceProp();
            if (ArrayPractice.Armstrong(153))
                Console.WriteLine("armstrong");
            else
                Console.WriteLine("NOT armstrong");

            ArrayPractice.PrimeNo(4);
            ArrayPractice.Fibo(4);
            for(int i=1; i<=10; i++)
            {
                if (ArrayPractice.PrimeNoBool(i))
                    Console.Write(i+" ");
            }

            /*
            //MyLib.MyLibFunctionStatic();
            MyLib myLib = new MyLib();
            myLib.MyLibFunctionNonSatic();
            Class1 a = new Class1();
            a.MyLib();
            */

            /*
            MethodHidingOverriding obj = new MethodHidingOverriding();
            obj.Show();   // Calls base Show()
            obj.Show1();  // Calls base virtual Show1()
            Console.WriteLine("----------------");
            obj = new MethodHiding();
            obj.Show();   // Calls base Show() — because Show() is hidden, not overridden
            obj.Show1();  // Calls base virtual Show1() — because MethodHiding doesn't override it
            Console.WriteLine("----------------");
            obj = new Overriding();
            obj.Show();   // Calls base Show() (Overriding doesn't hide Show())
            obj.Show1();  // Calls Overriding.Show1() because it's overridden   */

            /*
            OperatorOverloading obj1 = new OperatorOverloading(10,20);
            OperatorOverloading obj2 = new OperatorOverloading(5,5);
            OperatorOverloading obj3 = obj1 + obj2;
            obj3.print();
           Console.WriteLine( obj3.ToString());     */


            /*
            PaymentProcessor obj = new PaymentProcessor();
            obj.pay("DEBTIT","CVV",1000);       */

            /*
            Vehicle vehicle = new Vehicle();
            vehicle.emissionCehck();
            Console.WriteLine("----------------");
            vehicle = new Truck();
            vehicle.emissionCehck();
            Console.WriteLine("----------------");
            vehicle = new Bike();
            vehicle.emissionCehck();            */


            /*
            Console.WriteLine("\n----------------");
            Company company = new Company();
            company.DisplayPolicy();
            company = new ContractDept();
            company.DisplayPolicy(); */

            /*
            Class1 mylib = new Class1();
            mylib.var = 9;
            int sum ;
            int mult ;
            int num = 10;
            int num2 = 110;
            Console.WriteLine("i = " + num);
            mylib.add(ref num);
            Console.WriteLine("i = " + num); 

           
            void calc(int i, int j, out int ii, out int jj)
            {
                ii = i + j;
                jj = j * i;
            }
            calc(num,num2,out sum,out mult);*/


            Console.ReadKey();
        }
    
    }
}

