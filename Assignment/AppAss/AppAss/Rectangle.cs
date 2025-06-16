using System;

namespace CSharpMiniProjects
{
    public class Rectangle
    {
        private int Width = 5;
        private int Height = 5;

        public void PrintArea()
        {
            Console.WriteLine($"Area: {Width * Height}");
        }
    }
}