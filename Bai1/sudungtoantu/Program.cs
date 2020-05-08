using System;

namespace sudungtoantu
{
    class Program
    {
        static void Main(string[] args)
        {
            float height;
            float width;
            float area;
            Console.Write("Nhap chieu dai");
            height = float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong");
            width = float.Parse(Console.ReadLine());
            area= width* height;
            Console.WriteLine("Dien tich:"+ area);
            Console.ReadKey();

        }
    }
}
