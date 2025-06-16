using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    public class SimpleResource : IDisposable
    {
        private bool _disposed = false;

        public void UseResource()
        {
            if (_disposed)
                throw new ObjectDisposedException("SimpleResource");

            Console.WriteLine("Using the resource...");
        }
        // public implement of dispose
        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        // proteced implement of dispose
        // disposing parameter indicate whether method call
        // from Dispose method ture or finalize false
        public virtual void Dispose(bool dispose)
        {
            if (_disposed)
            {
                if (dispose)
                {
                    Console.WriteLine("Doing GC Work by Developer, HANDLE manage Resource ");
                }

                Console.WriteLine(" HANDLE UNmanage Resource ");
                _disposed = true;
            }

        }
        ~SimpleResource()// if developer Bhul gaya call kerne ka in main dispose call nai kia to destructor call hoga ok 
        {
            Dispose(false);
        }
    }
}
