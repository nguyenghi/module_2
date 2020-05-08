using System;
using System.Xml.Linq;

namespace BaiTap1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Nhap so hang cua mang: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot cua mang: ");
            int m = int.Parse(Console.ReadLine());
            int [,] array =CreateMatrix(n, m);
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write("{0} ", array[row, column]);
                }
                Console.WriteLine();
            }

            Console.WriteLine(ShowMaxRow(array));

        }
        public static int[,] CreateMatrix(int n, int m)
        {
     
                int[,] array = new int[n, m];
                Random rand = new Random();
                for (int row = 0; row < array.GetLength(0); row++)
                {
                    for (int column = 0; column < array.GetLength(1); column++)
                    {
                        array[row, column] = rand.Next(10, 50);
                    }
                }
                return array;
      
        }
        public static void Sum(int[,] array)
        {
            int sumrow = 0;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    sumrow = sumrow + array[row, column];
                }
                Console.WriteLine(sumrow);
            }
         }

        public static int ShowMaxRow(int [,] array)
        {

            int maxrow = 0;
            int sumrow = 0;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    sumrow = sumrow + array[row, column]; 
                }
                if(maxrow<sumrow)
                {
                    maxrow = sumrow;
                    sumrow = 0;
                }
            }
            return maxrow;
        }

    }
}
