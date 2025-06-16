using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    internal class EventAlaram
    {
        //step 1  defile delegate
        public delegate void alaramHandler();

        // step 2 event based on delegate
        public               alaramHandler OnAlaram;
        //public alaramHandler OnAlaram; // without event

        // step 3 method rased event
        public void CheckTime(int hr)
        {
            if (hr == 6)    
            {
                Console.WriteLine("Wakeup Arise");
                OnAlaram();
            }
            else
                Console.WriteLine("NOT time Yet");
        }

    }
}
