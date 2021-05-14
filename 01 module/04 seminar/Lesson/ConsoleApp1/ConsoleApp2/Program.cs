using System;

namespace ConsoleApp2
{
    class Program
    {
        static double[,] Sum(double[,] Results, int n)
        {
            double result = 0;

            for (int i = 1; i <= n; i++)
            {
                double Ai = (i + 0.3) / (3 * i * i + 5);

                result += Ai;

                Results[0, i - 1] = i;

                Results[1, i - 1] = result;
            }

            return Results;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[,] Results = new double[2, n];

            Results = Sum(Results, n);

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Results[0, i]:F3} \t");
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Results[1, i]:F3} \t");
            }
        }
    }
}
