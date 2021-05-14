using System;

namespace Task_01
{
    class Program
    {
        static bool F(double x, double y)
        {
            double rad = Math.Sqrt(x * x + y * y);

            int R = 2;

            if (rad <= R)
            {
                if (y >= 0 && x > y || x < 0) 
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            if (!double.TryParse(Console.ReadLine(), out double x) | !double.TryParse(Console.ReadLine(), out double y))
            {
                Console.WriteLine("Error");
                return;
            }

            Console.WriteLine("G = {}", F(x, y));
        }
    }
}
