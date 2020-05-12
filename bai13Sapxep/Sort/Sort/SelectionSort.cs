using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    class SelectionSorts
    {
        public void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            { 
                int min_idx = i;
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }

                }
                Helper.Swap(ref arr[min_idx], ref arr[i]);
            }
        }
    }
}
