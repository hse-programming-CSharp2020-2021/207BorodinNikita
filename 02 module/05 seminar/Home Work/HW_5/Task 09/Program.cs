using System;
using System.Linq;

namespace Task_09
{
    class LinearEquation
    {
        private double a;
        private double b;
        private double c;

        public double X
        {
            get
            {
                return a != 0 ? (c - b) / a : double.PositiveInfinity;
            }
        }

        public LinearEquation()
        {
            Random random = new Random();

            a = random.Next(-10, 10) + random.NextDouble();
            b = random.Next(-10, 10) + random.NextDouble();
            c = random.Next(-10, 10) + random.NextDouble();
        }

        public LinearEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override string ToString()
        {
            return $"{a}x + ({b}) = {c}{Environment.NewLine}x = {X}";
        }
    }
    class Program
    {
        static void Main()
        {
            do
            {
                Console.Clear();

                Console.Write("Enter the value of N: ");

                if (!uint.TryParse(Console.ReadLine(), out uint N))
                {
                    Console.WriteLine("Incorrect input.");
                    Console.WriteLine("Press any key to continue.");

                    Console.ReadKey();
                    continue;
                }

                LinearEquation[] equations = new LinearEquation[N];

                for (int index = 0; index < equations.Length; index++)
                {
                    Console.WriteLine();

                    equations[index] = new LinearEquation();
                    Console.WriteLine(equations[index].ToString());
                }

                equations = equations.OrderBy(item => item.X).ToArray();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nSort is complete.");
                Console.ResetColor();

                Array.ForEach(equations, item => Console.WriteLine($"\n{item}"));

                Console.WriteLine("\nPress Esc to exit or another key to continue");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
