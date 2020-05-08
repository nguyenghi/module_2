using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Mystack
    {
        private int[] arr;
        private int size;
        private int index = 0;
        public Mystack()
        {
        }
        public Mystack(int size)
        {
            this.size = size;
            arr = new int[size];
        }
         public void Push(int element)
        {
            arr[index] = element;

        }


    }
}
