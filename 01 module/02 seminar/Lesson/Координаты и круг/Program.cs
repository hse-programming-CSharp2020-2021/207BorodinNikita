using System;

namespace Координаты_и_круг
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int y = int.Parse(Console.ReadLine());

            string result = Math.Sqrt(x * x + y * y) <= 10 ? "Inside of the circle" : "Outside of the circle";

            Console.WriteLine(result);
        }
    }
}
