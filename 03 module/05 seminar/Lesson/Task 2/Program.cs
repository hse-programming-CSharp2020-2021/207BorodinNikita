using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static readonly char[] open = { '(', '[', '{' };
        static readonly char[] close = { ')', ']', '}' };

        static void Main(string[] args)
        {
            bool isCorrect = true;

            Stack<char> stack = new Stack<char>();
            int unclosedNumber = 0;

            string input = Console.ReadLine();

            foreach (var item in input)
            {
                if(Array.FindIndex(open, bracket => bracket == item) != -1)
                {
                    stack.Push(item);
                    unclosedNumber++;
                }
                else
                {
                    if(stack.Count != 0)
                    {
                        char bracket = stack.Pop();

                        if ((item == close[0] && bracket == open[0]) || (item == close[1] && bracket == open[1]) || (item == close[2] && bracket == open[2]))
                            unclosedNumber--;

                        else
                        {
                            isCorrect = false;
                            break;
                        }
                    }
                }
            }

            if(isCorrect && unclosedNumber == 0)
                Console.WriteLine("Correct.");

            else Console.WriteLine("Incorrect.");
        }
    }
}
