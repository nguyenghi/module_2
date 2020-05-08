using System;

namespace xoaphantu
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] arr = {4,5,3,5,7,4,3,2,4};
           int i, index, x;
           Console.WriteLine("Nhap gia tri can xoa");
           x = Int32.Parse( Console.ReadLine());
           bool find= false;
           for (i= 0; i< arr.Length; i++){
              if( arr[i]== x){
               Console.WriteLine("vi tri cua " + x + "la "+i);
               find= true;
               break;
               
               }
            }
             if( !find)
             {
                 Console.WriteLine("Khong tim thay");
             }
            index =i ;
            for( int j = index; j< arr.Length-1; j++)
            {
                arr[j]=arr[j+1];
            }
            for(int k =0; k< arr.Length; k++)
            {
             Console.WriteLine("{0}", arr[k]);
            }
             Console.ReadKey();

           
        }
    }
}
