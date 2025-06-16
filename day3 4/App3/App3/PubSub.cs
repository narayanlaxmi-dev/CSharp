using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    public class Pubisher
    {
        public Action<string> Notify;
        public void SendMessage(string message)
        {
            Notify(message);
        }
    }
    public class Subscriber
    {
        public string _name;
        public Subscriber(string _name)
        {
            this._name = _name;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Subscirber Name:{_name} received: {message}");
        }
    }
}
