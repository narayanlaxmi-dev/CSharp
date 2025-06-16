using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App
{
    internal class BankAccMangSys
    {
        public string holderName;
        public double balance;
        private static double Interest { get; set; }
        public static int count ;
        static BankAccMangSys()
        {
            Interest = 2.5;
            count++;
            Console.WriteLine($"Welcome to our bank intrest rate is {Interest}%");
            
        }

        public void set(string holderName, double balance)
        {
            this.holderName = holderName;
            this.balance = balance;

        }

        public void showAnnualIntrest()
        {
            double i = Interest / 100; // 2.5 / 100 = 0.025
            double sum = balance * i;
            Console.WriteLine($"Annual intrest is {sum} ");
        }
        public void showAcc()
        {
            Console.WriteLine($" Holder Name {holderName} \n Balance{balance} \n Intrest {Interest}");
        }

        public static void setIntrest(double i)
        {
            Interest = i;
            Console.WriteLine("Intrest updated");
        }
        public static int ShowAccountCount()
        {
            return count;
        }

    }
}
