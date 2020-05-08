using System;

namespace araymenu
{
    class Program
    {
        public static void Main(string[] args)
        {
          int option = -1;
            while (option != 0)
            {   
                Console.WriteLine("Menu");
                Console.WriteLine("1. Tao mang so nguyen 20 phan tu");
                Console.WriteLine("2. Hien thi mang");
                Console.WriteLine("3. Tong cac phan tu cua mang");
                Console.WriteLine("4. Hien thi so chan trong mang");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Nhap su lua chon ");

                option = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
            }  
        
        }
         public static void Action(int option, int[] array)
         {
            Console.Clear();
            switch (option)
            {
                case 1:
                     array = CreateArray();
                    break;
                case 2:
                    DisplayArray(array);
                    break;
                case 3:
                    SumArray(array);
                    break;
                case 4:
                    DisplayEven(array);
                    break;
                case 5:
                    Environment.Exit(Environment.ExitCode); 
                    break;    
            }
         }
         public static int[] CreateArray()
         {
                    int[] array = new int[20];
                    Random rnd = new Random();
                    for(int i = 0; i < array.Length; i++)
                    {
                        array[i] = rnd.Next(10, 50);
                    }
                    return array;
         }
         public static void DisplayArray(int[] array)
         {
             Console.WriteLine("Mảng của bạn là: [{0}]", string.Join(",", array));
         }
         public static void SumArray(int[] array)
         {
             int sum = 0;
            for (int i = 0; i < array.Length; i++)
             sum = sum + array[i];
             Console.WriteLine("Tổng các phần tử của mảng là: {0}", sum);
            
         }
         public static void DisplayEven(int [] array) 
         {
             Console.Write("Cac so chan co trong mang: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                Console.Write(array[i] + " ");
            }
                   
         }
    }
}
