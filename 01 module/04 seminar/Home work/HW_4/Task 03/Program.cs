using System;

namespace Task_03
{
    class Program
    {
        static void TabFunction(double a, double b, double c)
        {
            for (double x = 1, dx = 0.05, y = 0; Math.Round(x, 1) <= 2; x += dx)
            {
                if (x < 1.2)
                {
                    y = a * x * x + b * x + c;
                }
                if (Math.Round(x, 1) == 1.2)
                {
                    y = a / x + Math.Sqrt(x * x + 1);
                }
                if (x > 1.2)
                {
                    y = (a + b * x) / Math.Sqrt(x * x + 1);
                }

                Console.WriteLine($"y = {y:F2}, x = {x:F2}");
            }
        }
        static void FillFunction(int iterator, int letterNumber, ref double[] letters)
        {
            for (int i = 0; i < iterator; i++)
            {
                Console.WriteLine($"Введите параметр {(char)(letterNumber + i)}");
                if (!double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine("Incorrect input");
                    return;
                } 

                letters[i] = x;
            }
        }
        static void Main(string[] args)
        {
            double[] letters = new double[3]; 

            FillFunction(letters.Length, (int)'a', ref letters);

            TabFunction(letters[0], letters[1], letters[2]);
        }
    }
}
