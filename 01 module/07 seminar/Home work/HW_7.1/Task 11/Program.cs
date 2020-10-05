using System;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!uint.TryParse(Console.ReadLine(), out uint length) || length < 2)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            int[] myArray = new int[length];

            myArray[0] = 0; myArray[1] = 1;

            for (int i = 2; i < length; i++)
            {
                try { myArray[i] = checked(34 * myArray[i - 1] - myArray[i - 1] + 2); }

                catch (Exception) 
                { 
                    Console.WriteLine("Overflow error");
                    return;
                }
            }

            Array.ForEach(myArray, i => Console.Write($"{i} "));
        }
    }
}
