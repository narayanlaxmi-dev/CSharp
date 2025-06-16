using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    // class obj behave like array
    internal class Indexer
    {
        public int[] data = new int[5];

        public int this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        public void show()
        {
            foreach(int i in  data)
            Console.WriteLine(i);
        }
    }
}
