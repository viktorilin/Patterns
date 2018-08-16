using System;

namespace Patterns.Decorator
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape decoratedShape) : base(decoratedShape)
        {
       
        }
    
        public void draw()
        {
            decoratedShape.draw();
            setRedBorder(decoratedShape);
        }
        private void setRedBorder(Shape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}