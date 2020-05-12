using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[20];
            Helper.CrearArray(ref arr1); ;
            Console.WriteLine("--------before sort---------");
            Helper.ShowArray(arr1);
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.BubbleSorts(arr1);
            Console.WriteLine("--------- after bubble sort-----------");
            Helper.ShowArray(arr1);
            SelectionSorts selectionSorts = new SelectionSorts();
            selectionSorts.SelectionSort(arr1);
            Console.WriteLine("--------- after bubble sort-----------");
            Helper.ShowArray(arr1);
            InsertSort insertSort = new InsertSort();
            insertSort.InsertionSort(arr1);
            Console.WriteLine("--------- after insert sort-----------");
            Helper.ShowArray(arr1);





        }
    }
}
