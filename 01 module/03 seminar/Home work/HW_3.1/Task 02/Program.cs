using System;

namespace Task_02
{
    class Program
    {
        static uint Reverse(uint input)
        {
            uint length = 0, temporary = input; double result = 0;

            while (temporary != 0)
            {
                length++;

                temporary = (temporary - temporary % 10) / 10;
            }

            for (int i = 1; input != 0; i++)
            {
                result += (input % 10) * Math.Pow(10, length - i);

                input = (input - input % 10) / 10;
            }

            return (uint)result;
        }
        static void Main(string[] args)
        {
            if(!uint.TryParse(Console.ReadLine(), out uint input))
            {
                Console.WriteLine("Error");
                return;
            }

            Console.WriteLine(Reverse(input));
        }
    }
}
