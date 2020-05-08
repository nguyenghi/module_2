using System;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5, "red", true);
            Console.WriteLine(triangle.ToString());
        }
    }
}
