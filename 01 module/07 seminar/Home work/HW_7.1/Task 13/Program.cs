using System;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!uint.TryParse(Console.ReadLine(), out uint length) || length == 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            if (!uint.TryParse(Console.ReadLine(), out uint k) || k > length || k == 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int[] myArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                Random random = new Random();

                myArray[i] = random.Next(-10, 11);
            }

            for (uint i = 0; i < length; i += k)
            {
                Console.Write($"{myArray[i]} ");
            }
        }
    }
}
