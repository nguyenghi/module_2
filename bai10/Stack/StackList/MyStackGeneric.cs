using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace StackList
{
     public class MyStackGeneric <T>
    {
        private LinkedList<T> stack;
        public MyStackGeneric()
        {
            stack = new LinkedList<T>();
        }
        public int Size()
        {
            return stack.Count;
        }
        public bool IsEmpty()
        {
            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }
        public void Push(T element)
        {
            stack.AddFirst(element);
        }
        public void Pop()
        {
            if (IsEmpty())
            {
                throw new Exception();
            }
            stack.RemoveFirst();
        }





    }
}
