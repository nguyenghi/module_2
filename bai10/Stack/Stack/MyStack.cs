using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Stack
{
    class MyStack
    {
        private int[] arr;
        private int size;
        private int index = 0;
        public int Size
        {
            get => size;
            set => size = value;
        } 

        public MyStack(int size)
        {
            this.size = size;
            arr = new int[size];
        }
        public bool IsEmpty()
        {
            if (index == 0)
            {
                return true;
            }
            return false;
        }
        public bool IsFull()
        {
            if (index == size)
            {
                return true;
            }
            return false;
        }
        public void Push(int element)
        {
            if (IsFull())
            {
                throw new Exception("Stack is full");
            }
            arr[index] = element;
            index++;
        }
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is null");
            }
            return arr[--index];
        }
    }
}
