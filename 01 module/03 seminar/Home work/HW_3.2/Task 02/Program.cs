using System;

namespace Task_02
{
    class Program
    {
        static double F(double x, double y)
        {
            switch (x < y && x > 0)
            {
                case true:
                    return x + Math.Sin(y);
                case false:
                    switch (x > y && x < 0) 
                    {
                        case true:
                            return y - Math.Cos(x);
                        default:
                            return 0.5 * x * y;
                    }
            }

        }
        static void Main(string[] args)
        {
            if (!double.TryParse(Console.ReadLine(), out double x) | !double.TryParse(Console.ReadLine(), out double y))
            {
                Console.WriteLine("Error");
                return;
            }

            Console.WriteLine("G = {0:F3}", F(x, y));
        }
    }
}
