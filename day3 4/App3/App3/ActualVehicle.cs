using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    internal class ActualVehicle
    {
        public class Car : IVehicle
        {
            private double price;
           public Car(double price) { this.price = price; }

            public string Type 
            {
                get { return "car"; } 
            }
            public double Price
            {
                get { return price; }
            }

           
        }
        public class Bike : IVehicle
        {
            private double price;
            public Bike(double price) { this.price = price; }
            public string Type => "Bike"; // or
            //public string Type {
            //    get { return "Bike"; }
            //}
            public double Price => price;

            
        }

        public class Scooty : IVehicle
        {
            private double price;
            public Scooty(double price) { this.price = price; }
            public string Type => "Scooty";
            public double Price => price;


        }
    }
}
