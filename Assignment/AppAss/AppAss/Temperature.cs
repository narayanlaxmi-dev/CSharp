using System;

namespace CSharpMiniProjects
{
    public class Temperature
    {
        private int v;
        public int Value
        {
            get => v;
            set
            {
                if (value < -30 || value > 50)
                    Console.WriteLine("Warning: Value out of range (-30 to 50)");
                
                else
                {
                    v = value;
                    Console.WriteLine($"Temperature set to {value}");
                }
            }
        }
    }
}