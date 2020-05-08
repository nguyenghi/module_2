using System;

namespace baitap3
{
    class Program
    {
        static void Main(string[] args)
        { int [,] array = CreatArray();
        Console.WriteLine("Hien thi mang voi gia tri v");
    
          DisplayArrayV(array);
        Console.WriteLine("Hien thi mang voi boi cua 5");
          DisplayArray5(array);
        Console.WriteLine("Mang mn:");
         CreatnewArray(array);
        Console.ReadKey();
        
            
        }
        static int[,] CreatArray()
        {           Console.Write("Nhap so hang cua mang n: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.Write("Nhap so cot cua mang m: ");
                    int m = int.Parse(Console.ReadLine());
                    int[,] array = new int[n,m];
                    Random rand = new Random();
                    for (int row = 0; row < array.GetLength(0); row++)
                    {
                        for (int column = 0; column < array.GetLength(1); column++)
                        {
                    array[row, column] = rand.Next(20,60);
                        }
                    }
                    return array;
        }
         static void DisplayArrayV(int[,] array)
        {           Console.Write("Nhap v: ");
                    int v = int.Parse(Console.ReadLine());
           for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(v >= 20 && v <= 60 &&  array[i,j] == v){
                        Console.WriteLine(array[i,j]+" ");
                    }
                }
            }

        } 
        static void DisplayArray5(int[,] array)
         {
             for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if( array[i,j] % 5 == 0)
                    {
                        Console.WriteLine(array[i,j]+" ");
                    }
                }
            }
        }
         static int[,] CreatnewArray(int[,] array)
        {    int m = array.GetLength(1);
             int n = array.GetLength(0) ;    
             int [,] newarray =  new int [m,n] ;
                    
                    for (int row = 0; row < newarray.GetLength(0); row++)
                    {
                        for (int column = 0; column < newarray.GetLength(1); column++)
                        { for (int i = 0; i < m; i++)
                            {
                                Console.WriteLine("\n");
                                for (int j = 0; j < n; j++)
                                {
                                    newarray[row,column]= array[j,i];
                                }
                            }
                          
                        }
                    }
                    return newarray;
        }

    }
}
