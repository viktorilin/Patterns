using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Adapter;
using Patterns.Builder;
using Patterns.Decorator;
using Patterns.Facade;
using Patterns.Factory_method;
using Patterns.Singleton;
using Patterns.Strategy;


namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = null;
            while (x != "break")
            {
                Console.WriteLine("Input name of pattern");
                x = Console.ReadLine();
                switch (x)
                {
                    case "singleton":
                        Singleton();
                        Console.WriteLine("****************************");
                        break;
                    case "builder":
                        Builder();
                        Console.WriteLine("****************************");
                        break;
                    case "strategy":
                        Strategy();
                        Console.WriteLine("****************************");
                        break;
                    case "facade":
                        Facade();
                        Console.WriteLine("****************************");
                        break;
                    case "adapter":
                        Adapter();
                        Console.WriteLine("****************************");
                        break;
                    case "decorator":
                        Decorator();
                        Console.WriteLine("****************************");
                        break;
                }
            }
        }

        private static void Singleton()
        {
            ConnectionDB connectionDB = ConnectionDB.getInstance();
            ConnectionDB connectionDB1 = ConnectionDB.getInstance();
        }

        private static void Builder()
        {
            var tripBuilder = new TripLaptopBuilder();
            var gamingBuilder = new GamingLaptopBuilder();
            var shopForYou = new BuyLaptop();
            shopForYou.SetLaptopBuilder(gamingBuilder);
            shopForYou.ConstructLaptop();
            Laptop laptop = shopForYou.GetLaptop();
            Console.WriteLine(laptop.ToString());
        }

        private static void Strategy()
        {
            var me = new Myself();
            me.ChangeStrategy(new RainWearingStrategy());
            me.GoOutside();
            var myFriend = new Myself();
            myFriend.ChangeStrategy(new SunshineWearingStrategy());
            myFriend.GoOutside();
        }

        private static void FactoryMethod()
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            Factory_method.Shape shape1 = shapeFactory.getShape("CIRCLE");
            shape1.draw();
            Factory_method.Shape shape2 = shapeFactory.getShape("RECTANGLE");
            shape2.draw();
            Factory_method.Shape shape3 = shapeFactory.getShape("SQUARE");
            shape3.draw();
        }

        private static void Facade()
        {
            ShapeMaker shapeMaker = new ShapeMaker();
            shapeMaker.drawCircle();
            shapeMaker.drawRectangle();
            shapeMaker.drawSquare();
        }

        private static void Adapter()
        {
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.Play("mp3", "beyond the horizon.mp3");
            audioPlayer.Play("mp4", "alone.mp4");
            audioPlayer.Play("vlc", "far far away.vlc");
            audioPlayer.Play("avi", "mind me.avi");
        }

        private static void Decorator()
        {
            Decorator.Shape circle = new Decorator.Circle();
            Decorator.Shape redCircle = new RedShapeDecorator(new Decorator.Circle());
            Decorator.Shape redRectangle = new RedShapeDecorator(new Decorator.Rectangle());
            Console.WriteLine("Circle with normal border");
            circle.draw();
            Console.WriteLine("\nCircle of red border");
            redCircle.draw();
            Console.WriteLine("\nRectangle of red border");
            redRectangle.draw();
        }
    }
}