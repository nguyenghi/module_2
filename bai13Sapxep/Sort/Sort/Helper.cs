using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public class Helper
    {
        public static void CrearArray( ref int [] arr)
        {
            Random rd = new Random();
            for ( int i =0; i< arr.Length; i++)
            {
                arr[i] = rd.Next(0, 100);
            }
        }
        public static void Swap(ref int a, ref int b)

        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            

        }
        public static void ShowArray(int [] arr)
        {
           for(int i =0; i< arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]}");
            }
        }
        public static int IndexMinArrar(int [] arr)
        {
            int index= 0;
            int minarr = arr[0];
            for(int i = 0; i< arr.Length; i++)
            {
                if(arr[i]< minarr)
                {
                    minarr = arr[i];
                    index = i;
                }
            }
            return index;

        }

    }
}
