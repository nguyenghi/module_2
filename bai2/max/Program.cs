﻿using System;

namespace max
{
    class Program
    {
        static void Main(string[] args)
        {
              int[,] array = new int[5,5];
                    Random rand = new Random();
                    for (int row = 0; row < array.GetLength(0); row++)
                    {
                        for (int column = 0; column < array.GetLength(1); column++)
                        {
                    array[row, column] = rand.Next() * 10;
                        }
                    }
              for (int row = 0; row < array.GetLength(0); row++)
            {
                Console.WriteLine("\n");
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write(array[row, column] + " ");
                }
            }
             int max = array[0,0];
            for (int row = 0; row < array.GetLength(0); row++)
            {
                
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    if(array[row,column]> max)
                    {
                        max = array[row,column];
                    }
                }
            }
            Console.WriteLine("\n"+" Gia tri lon nhat: {0}",max);



        }
    }
}
