using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            double c = double.Parse(Console.ReadLine());
            QuadraticEquation quad= new QuadraticEquation(a,b,c);
            Console.WriteLine(quad.Getter());
            Console.WriteLine("Giai phuong trinh");
            double delta = quad.GetDiscriminant();
            if( delta > 0){
                Console.WriteLine( "Phuong trinh co 2 nghiem"+"x1=" + quad.GetRoot1(delta)"\n x2="+ quad.GetRoot2(delta));
            } else if( delta == 0){
                Console.WriteLine(" Phuong trinh co nghiem kep "+ (-b/(2*a)));

            } else{
                Console.WriteLine("Phuong trinh vo nghiem");
            }
             Console.ReadLine();
             Console.ReadKey();
        
    }
}
}
