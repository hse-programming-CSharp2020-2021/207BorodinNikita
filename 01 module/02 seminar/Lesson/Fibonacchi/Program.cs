using System;

namespace Fibonacchi
{
    class Program
    {
        static void Fibonacchi()
        {
            double number;

            if (double.TryParse(Console.ReadLine(), out number) && number > 0)
            {
                double b = Math.Pow((1 + Math.Sqrt(5)) / 2, number);

                double c = Math.Pow((1 - Math.Sqrt(5)) / 2, number);

                double result = (1 / Math.Sqrt(5)) * (b - c);

                Console.WriteLine(Math.Round(result, 0));
            }
            else
            {
                Console.WriteLine("Ошибка!");
            }
        }
        static void Main(string[] args)
        {
            Fibonacchi();
        }
    }
}
