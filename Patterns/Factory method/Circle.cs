using System;

namespace Patterns.Factory_method
{
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}