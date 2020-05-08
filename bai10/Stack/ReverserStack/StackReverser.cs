using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace ReverserStack
{
    class StackReverser
    {
        private int[] arr;
        private int size;
        private int index = 0;
        public int Size
        {
            get => size;
            set => size = value;
        }
        public StackReverser(int size)
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
            
            arr[index] = element;
            index++;
        }
        public int Pop()
        {
            
            return arr[--index];
        }
        public void ReserverStack(Stack st)
        {
           
            while (st.Count != 0)
            {
                for (int i = 0; i < st.Count; i++)
                {
                    object x = st.Pop();
                    arr[i] = x;
                }
                Console.WriteLine();
                while (st.Count != 0)
                {
                    rev.Push(st.Pop());
                }
            }
        }

    }

        
    }
