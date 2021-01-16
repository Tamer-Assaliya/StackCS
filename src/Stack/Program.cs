using System;
using System.Collections.Generic;

namespace MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            string[] stringArray = { "hi", "hello", "hey" };
            MyStack<int> intStack = new MyStack<int>();
            MyStack<string> stringStack = new MyStack<string>();
            foreach (var val in intArray)
                intStack.Push(val);
            foreach (var val in stringArray)
                stringStack.Push(val);
            intStack.Print();
            stringStack.Print();
            intStack.Pop(); intStack.Pop(); intStack.Peek();
            intStack.Print();
            stringStack.Pop(); stringStack.Pop();
            stringStack.Print();
            stringStack.Pop();
            try { stringStack.Pop(); }
            catch { }
        }
    }
}
