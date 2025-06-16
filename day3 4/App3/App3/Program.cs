using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static App3.EventAlaram;

namespace App3
{
    public delegate int Operation(int a, int b);
    internal class Program
    {
        // refrence function to HelloFunc func
        delegate void myDeligate(); // it treat like class to we want to create obj
        delegate void myDeligate2();
        delegate void myDeligate3(int a);
        public delegate void AlaramHandler2();
        static void Main(string[] args)
        {
            /*
              DeligateEx obj1 = new DeligateEx();
              //obj1.ShowDetails();
              myDeligate del4 = new myDeligate(obj1.ShowDetails);
              del4();

              Console.WriteLine("_____________________________---------");
              myDeligate2 del1, del2, del3, del5;
              del1 = new myDeligate2(HelloFunc);
              del2 = new myDeligate2(ShowDetails);
              del3 = del1 + del2;
              del5 = del1 + del2 - del1;
              del3();
              Console.WriteLine("---");
              del5();
            */

            /*
            OperationDelegate op1 = new OperationDelegate();
            Operation opdel = new Operation(op1.Add);
            op1.ExecutionOperation(12, 2, opdel);
            op1.ExecutionOperation(12, 2, new Operation(op1.Sub)); */


            /*
            IVehicle car = new ActualVehicle.Car(4000);
            IVehicle bike = new ActualVehicle.Bike(5000);
            

            TaxService carService =new TaxService(new TaxDelegate(TaxLogic.CalcCarTax)); // internally this work 
            TaxService bikeService =new TaxService(TaxLogic.CalcBikeTax);
            carService.PrintTax(car);
            bikeService.PrintTax(bike);

            IVehicle scoo = new ActualVehicle.Scooty(5000);
            TaxService scootyService = new TaxService();
            scootyService.PrintTax(scoo, TaxLogic. CalcScootyTax);*/
            

            /*
            Pubisher pubisher = new Pubisher();

            Subscriber sub1 = new Subscriber("Shiva");
            Subscriber sub2 = new Subscriber("Nara");

            pubisher.Notify += sub1.ReceiveMessage;
            pubisher.Notify += sub2.ReceiveMessage;

            pubisher.SendMessage("The Message send...");*/

            EventAlaram alarm = new EventAlaram();
            alarm.OnAlaram += AriseEvent;


            

            alarm.CheckTime(5);
            alarm.CheckTime(6);




        }
        public static void AriseEvent()
        {
            Console.WriteLine("😈👿Get The Hello UP its time To Level up 😈👿");
        }
      

        public static void HelloFunc()
        {
            Console.WriteLine("Hello Func i called using delegate function");
        }

        public static void ShowDetails()
        {
            Console.WriteLine("HelloDelegateEx Class");
        }
    }
}
