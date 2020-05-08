using System;

namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        { int[,] array = CreatArray();
         Console.Write("Tong cac so chan:"+ SumEven(array) +"\n");
         Console.WriteLine("Hien thi mang"+"\n");
         DisplayArray(array);
         Console.WriteLine("\n"+"Hien thi tam giac duoi"+"\n");
         DisplayTriangle(array);
         Console.WriteLine("\n"+"Hien thi tam giac tren"+"\n");
         DisplayOverTriangle(array);
         Console.WriteLine("\n"+"Tong duong cheo chinh: "+ SumCheochinh(array)+"\n");
         Console.WriteLine("\n"+"Tong duong cheo phu: "+ SumCheophu(array)+"\n");
         Console.WriteLine("\n"+" Tong duong vien: "+SumVien(array)+"\n");

        
        Console.ReadKey();
            
        }
        static int[,] CreatArray()
        {           Console.Write("Nhap so hang, so cot cua mang: ");
                    int n = int.Parse(Console.ReadLine());
                    int[,] array = new int[n,n];
                    Random rand = new Random();
                    for (int row = 0; row < array.GetLength(0); row++)
                    {
                        for (int column = 0; column < array.GetLength(1); column++)
                        {
                    array[row, column] = rand.Next(10,90);
                        }
                    }
                    return array;
        }
        static int SumEven(int[,] array)
        {   int sum = 0;
            for(int i = 0;i < array.GetLength(0);i++)
            {
                for ( int j =0; j< array.GetLength(1); j++)
                { if ( array[i,j]% 2 == 0)
                    { sum= sum + array[i,j];

                    }
                }
            }
            return sum;
        }
         static void DisplayArray(int[,] array)
        {
           for (int row = 0; row < array.GetLength(0); row++)
            {
                Console.WriteLine("\n");
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write(array[row, column] + " ");
                }
            }

        }
         static void DisplayTriangle(int[,] array)
        {
           for (int row = 0; row < array.GetLength(0); row++)
            {
                Console.WriteLine("\n");
                for (int column = 0; column < array.GetLength(1); column++)
                { if( column <= row)
                   { Console.Write(array[row, column] + " ");}
                }
            }

        }
        static void DisplayOverTriangle(int[,] array)
        {
           for (int row = 0; row < array.GetLength(0); row++)
            {
                Console.WriteLine("\n");
                for (int column = 0; column < array.GetLength(1); column++)
                { if( column >= row)
                   { Console.Write(array[row, column] + " ");}
                   else
                   {
                    Console.Write("  ");
                   } 

                   
                }
                
            }

        }
        static int SumVien(int[,] array)
        {   int sum = 0;
            for(int i = 0;i < array.GetLength(0);i++)
            {
                for ( int j =0; j< array.GetLength(1); j++)
                { if (i==0||i ==( array.GetLength(0)-1)||j == 0|| j== (array.GetLength(1)-1))
                    { sum= sum + array[i,j];

                    }
                }
            }
            return sum;
        }
        static int SumCheochinh(int[,] array)
        {   int sum = 0;
            for(int i = 0;i < array.GetLength(0);i++)
            {
                for ( int j =0; j< array.GetLength(1); j++)
                { if (i ==j )
                    { sum= sum + array[i,j];

                    }
                }
            }
            return sum;

        }
         static int SumCheophu(int[,] array)
        {   int sum = 0;
            int n = array.GetLength(0);
            for(int i = 0;i < array.GetLength(0);i++)
            {   
                n= n-1;
                for ( int j =0; j< array.GetLength(1); j++)
                { if (j== n )
                    { sum= sum + array[i,j];

                    }
                }
            }
            return sum;
            }

    }
}
