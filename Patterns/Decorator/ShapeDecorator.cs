namespace Patterns.Decorator
{
    public abstract class ShapeDecorator : Shape
    {
        protected Shape decoratedShape;
        public ShapeDecorator(Shape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }
        public void draw()
        {
            decoratedShape.draw();
        }
    }
}