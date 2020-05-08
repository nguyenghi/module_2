using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();

            Console.WriteLine(shape);

            shape = new Shape("red", false);

            Console.WriteLine(shape);
            Console.WriteLine("------------------------");
            Circle circle = new Circle();

                Console.WriteLine(circle);
                circle = new Circle(3.5);
                Console.WriteLine(circle);
                circle = new Circle(3.5, "indigo", false);
                Console.WriteLine(circle);
        }
    }
    
   
}
