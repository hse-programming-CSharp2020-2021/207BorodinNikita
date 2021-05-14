using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "5 / 3 = " + 5 / 3;

            Console.WriteLine(result);

            result = "5.0 / 3.0 = " + 5 / (double)3;

            Console.WriteLine(result);

            result = 5 / 3 + " - это 5 / 3";

            Console.WriteLine(result);

            result = (5.0 / 3.0).ToString("F");

            Console.WriteLine(result);

            result = (5.0 / 3.0).ToString("F4");

            Console.WriteLine(result);

            result = (5.0 / 3.0).ToString("E");

            Console.WriteLine(result);

            result = (5.0 / 3.0).ToString("E5");

            Console.WriteLine(result);

            result = (5.0 / 3.0).ToString("G");

            Console.WriteLine(result);

            result = (5.0 / 3.0).ToString("G3");

            Console.WriteLine(result);

            result = (5.0 / 3e10).ToString("G3");

            Console.WriteLine(result);

            result = (5.0 / 3e-10).ToString("G");

            Console.WriteLine(result);

            result = (5.0 / 3e-20).ToString("G");

            Console.WriteLine(result);

            Console.ReadLine(); 
        }
    }
}
