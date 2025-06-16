using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//metree.in
namespace App
{
    static class ExtensionMethod1
    {
        public static void DemoStudent1(this Book m)
        {
            Console.WriteLine("Bhai Bhai to all Students");
        }
    }

    internal class Program
    {
        //this is properties to get age and name 
        //shortcut  prop tab tab change name

        public int Age { get; set; }

        public static void printName(string name = "hello")
        {
            Console.WriteLine($"name id : {name}");
        }

        public static void paramPrint(params int[] age) // we dont konw how many parameter required
        {
            foreach (int a in age)
                Console.WriteLine(a);
        }


        static void Main(string[] args)
        {
         

            /*
            Console.WriteLine("Hello world");
            printName(name: "NARA"); // or
            printName("123");
            paramPrint(1, 2, 3, 4, 5);  */

            /*
            Student1 std = new Student1();
            std.Id = 1;
            std.Name = "Nara";
            Console.WriteLine(std.ToString());
            Console.WriteLine(std.Id);
            Console.WriteLine(std.Name);    */

            /*
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();     
            Console.WriteLine(s1.retunCount()); */

            //          write a prog to get count of prime no from 1 to 100
            /* Student s1 = new Student();
             s1.primeNumberCount();*/

            /*
            Book book1 = new Book(1,"fight","arts of fight","motivational");
            book1.show();
            Book bb1 = new Book(book1);
            bb1.show();     */


            /*
            BankAccMangSys b1 = new BankAccMangSys();
            b1.set("nara", 50000);
            b1.showAcc();
            b1.showAnnualIntrest();
            BankAccMangSys.setIntrest(5);

            Console.WriteLine("----------------------------------");
            BankAccMangSys b2 = new BankAccMangSys();
            b2.set("yana", 60000);
            b2.showAcc();

            b2.showAnnualIntrest();
            b1.showAcc();
            b1.showAnnualIntrest();
            Console.WriteLine("\n\nTotal account Created : "+ BankAccMangSys.ShowAccountCount());       */


            Student s1 = new Student();
            s1.DemoStudent();
            //s1.DemoStudent1();
        }
    }

}
