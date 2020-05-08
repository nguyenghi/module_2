using System;

namespace gopmang
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arr1= new int[2];
           int[] arr2= new int[3];
           Console.WriteLine("nhap phan tu cho mang 1");
           for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
           Console.WriteLine("nhap phan tu cho mang 2");
           for (int j = 0; j < arr2.Length; j++)
            {
                Console.Write("Phan tu - {0}: ", j);
                arr2[j] = Convert.ToInt32(Console.ReadLine());
            }

           int[] arr3 = new int[arr1.Length+arr2.Length];
            for ( int i = 0; i < arr1.Length; i++){
                arr3[i]= arr1[i];
            }
             for ( int j = 0; j < arr2.Length; j++){
                 arr3[arr1.Length+j]= arr2[j];
                
             }
             Console.WriteLine("Sau khi gop");
             for(int k=0; k< arr3.Length; k++){
                 Console.WriteLine("{0}",arr3[k]);
             }
        }
    }
}
