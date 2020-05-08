using System;
using System.Collections.Generic;
using System.Text;

namespace StackList
{
    class StackOfInt
    {
        public void StackOfIntegers()
        {
            MyStackGeneric<int> stack = new MyStackGeneric<int>();
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            Console.WriteLine("2.1. Size of stack after push operations: " + stack.Size());
            Console.WriteLine("2.2. Pop elements from stack..");
            
                stack.Pop();
            
            Console.WriteLine("\n3.3 Size of stack after pop operations : " + stack.Size());
        }
        public void StackOfIStrings()
        {
            MyStackGeneric<string> stack = new MyStackGeneric<string>();
            stack.Push("Five");
            stack.Push("Four");
            stack.Push("Three");
            stack.Push("Two");
            stack.Push("One");
            Console.WriteLine("1.1 Size of stack after push operations: " + stack.Size());
            Console.WriteLine("1.2. Pop elements from stack..");
            while (!stack.IsEmpty())
            {
                stack.Pop();
            }
            Console.WriteLine("\n1.3. Size of stack after pop operations : " + stack.Size());
        }
    }
}
