using System;

namespace Patterns.Decorator
{
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }
}