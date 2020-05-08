using System;
using System.Collections.Immutable;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle[] circles = new Circle[3];
            circles[0] = new Circle(2.6,"red",true);
            circles[1] = new Circle(5, "blue", true);
            circles[2] = new Circle(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }


           CircleComparator circleComparator = new CircleComparator();
            Array.Sort(circles, circleComparator);


            Console.WriteLine("After-sorted:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }
           
        }
    }
}
