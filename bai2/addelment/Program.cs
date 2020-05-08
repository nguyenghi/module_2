using System;

namespace addelment
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = {4, 12, 7, 8, 1, 6, 9};
            int x, index, i;
            Console.Write("Nhap so can chen:");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap vi tri can chen:");
            index = Int32.Parse(Console.ReadLine());
            if(index > arr.Length)
            {
                Console.WriteLine("Khong tim thay vi tri can chen");
            }
            else{
                Array.Resize(ref arr, arr.Length + 1);
                for (i = arr.Length-1; i > index; i--){
                    arr[i]= arr[i-1];
                }
                arr[index] = x;
                
                for(int j = 0; j< arr.Length; j++)
                {
                    Console.WriteLine("{0} ,",arr[j]);
                }
            }
            
            Console.ReadLine();

        }
    }
}
