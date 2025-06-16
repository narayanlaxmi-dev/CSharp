using System;

namespace CSharpMiniProjects
{
    public class Circle
    {
        public double Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;
    }
}