using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal class PaymentProcessor
    {
         public  void pay(string creditNo, string cvv, double amt)
        {
            Console.WriteLine("Default Method");
            Console.WriteLine($" {creditNo}, {cvv} , {amt}");

        }
    }

    class Paypal : PaymentProcessor
    {
     
        public  void pay(string upiId, double amt,int f) {
            Console.WriteLine($" {upiId}, {amt} ");
        }
    }
    class RazorPay : PaymentProcessor
    {
       
        public  void pay(int debitNo, string cvv,string pin, double amt) {
            Console.WriteLine($" {debitNo}, {cvv} ,{pin} , {amt}");
        }
    }
}
