using System;

namespace tong1cot
{
    class Program
    {
        static void Main(string[] args)
        {  int row, col;
            Console.Write("Nhap so hang: ");
            row =Int32.Parse( Console.ReadLine());
             Console.Write("Nhap so cot: ");
            col =Int32.Parse( Console.ReadLine());
            int[,] arr = new int[row,col];
            for(int i =0; i < arr.GetLength(0);i++)
            {
                for(int j =0 ; j < arr.GetLength(1); j++)
                {
                    Console.Write("nhap phan tu: [{0},{1}]",i,j);
                    arr[i,j]= Int32.Parse(Console.ReadLine());
                }
            }
            int sum = 0;
            Console.Write(" nhap cot can tinh tong: ");
            int cols = Int32.Parse(Console.ReadLine());
            if(cols< arr.GetLength(1))
            {
            for(int i =0; i < arr.GetLength(0);i++)
                {
                    sum = sum + arr[i, cols];
                }
            Console.WriteLine("tong cua cot "+cols+ "la: "+ sum );
            }

        }
        
    }
}
