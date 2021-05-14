using System;

namespace Task_05
{
    class Program
    {
        private delegate double Calculate(int x);
        static void Main(string[] args)
        {
            Calculate polynomCalc = x =>
            {
                double result = 0;

                for (int i = 1; i <= 5; i++)
                {
                    double add = 1;

                    for (int j = 1; j <= 5; j++)
                    {
                        add *= i * x / j;
                    }

                    result += add;
                }

                return result;
            };

            Console.WriteLine(polynomCalc(Convert.ToInt32(Console.ReadLine())));
        }
    }
}
