using System;

namespace Patterns.Decorator
{
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Shape: Rectangle");
        }
    }
}