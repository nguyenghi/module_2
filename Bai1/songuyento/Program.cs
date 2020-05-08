using System;

namespace songuyento
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Nhap so nguyen:");
            num= Convert.ToInt32(Console.ReadLine());
            if (num< 2){
               Console.WriteLine(num+"k la so nguyen to");
            }
            else
            {   int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(num))
                {
                    if (num % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                    Console.WriteLine(num + "  la so nguyen to");
                else
                    Console.WriteLine(num + " k la so nguyen to");

            }
              
        }
    }
}
