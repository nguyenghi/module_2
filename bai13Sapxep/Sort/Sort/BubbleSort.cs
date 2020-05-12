using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    class BubbleSort
    {
     public void BubbleSorts(int[] arr)
        {
            bool needtoSort = true;
            for (int k = 1; k < arr.Length && needtoSort; k++)
            {
                needtoSort = false;
                for (int i = 0; i < arr.Length - k; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Helper.Swap(ref arr[i], ref arr[i + 1]);
                        needtoSort = true;
                    }
                }

            }
        }
    }
}
