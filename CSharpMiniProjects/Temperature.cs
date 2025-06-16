using System;

namespace CSharpMiniProjects
{
    public class Temperature
    {
        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                if (value < -30 || value > 50)
                {
                    Console.WriteLine("Warning: Value out of range (-30 to 50)");
                }
                else
                {
                    _value = value;
                    Console.WriteLine($"Temperature set to {value}");
                }
            }
        }
    }
}