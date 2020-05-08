using System;

namespace baitap2
{
    class Program
    {
        static void Main(string[] args)
        { int [,] array1 = CreatArray();
          int [,] array2 = CreatArray();
          Console.WriteLine("Tong cua hai mang: " +(SumArray(array1) + SumArray(array2)));
          Console.WriteLine("Tich cua hai mang: "+ (MulArray(array1) * MulArray(array2)));
          Console.ReadKey();

         
        }
         static int[,] CreatArray()
        {           Console.Write("Nhap so hang, so cot cua mang vuong: ");
                    int n = int.Parse(Console.ReadLine());
                    int[,] array = new int[n,n];
                    Random rand = new Random();
                    for (int row = 0; row < array.GetLength(0); row++)
                    {
                        for (int column = 0; column < array.GetLength(1); column++)
                        {
                    array[row, column] = rand.Next(10,40);
                        }
                    }
                    return array;
        }
        static int SumArray(int[,] array)
        {   int sum = 0;
            for(int i = 0;i < array.GetLength(0);i++)
            {
                for ( int j =0; j< array.GetLength(1); j++)
                { 
                     sum= sum + array[i,j];

                    
                }
            }
            return sum;
        }
        static int MulArray(int[,] array)
        {   int mul = 1;
            for(int i = 0;i < array.GetLength(0);i++)
            {
                for ( int j =0; j< array.GetLength(1); j++)
                { 
                    mul= mul* array[i,j];
                }
            }
            return mul;
        }
    }
}
