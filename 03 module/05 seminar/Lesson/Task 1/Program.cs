using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 N = Convert.ToInt32(Console.ReadLine());

            LinkedList<int> list = new LinkedList<int>();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; N > 0; i++)
            {
                list.AddFirst(N % 10);
                stack.Push(N % 10);

                N /= 10;
            }

            foreach (var item in list)
                Console.Write(item);

            Console.WriteLine();

            foreach (var item in stack)
                Console.Write(item);
        }
    }
}
