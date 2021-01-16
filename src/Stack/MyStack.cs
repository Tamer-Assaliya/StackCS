using System;
using System.Collections.Generic;
using System.Linq;

namespace MyStack
{
    public interface IMyStack<T>
    {
        void Push(T value);
        T Pop();
        void Print();
        T Peek();
        void Clear();
    }
    public class MyStack<T> : IMyStack<T>
    {
        private List<T> StackList = new List<T>();
        public void Push(T value)
        {
            StackList.Add(value);
            Console.WriteLine($"{value} pushed");
        }
        public T Pop()
        {
            try
            {
                T last = StackList[StackList.Count - 1];
                StackList.RemoveAt(StackList.Count - 1);
                Console.WriteLine($"{last} poped");
                return last;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        public void Print()
        {
            Console.WriteLine($"Printing stack elements:");
            foreach (var value in Enumerable.Reverse(StackList))
            {
                Console.Write($"{value}, ");
            }
            Console.WriteLine();
        }
        public T Peek()
        {
            try
            {
                T last = StackList[StackList.Count - 1];
                Console.WriteLine($"{last} on top");
                return last;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }


        }
        public void Clear()
        {
            Console.WriteLine($"Clearing the stack..");
            StackList.Clear();
        }
    }
}