using System;

namespace Окружность
{
    class Program
    {
        public static double Square(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double Length(double radius)
        {
            return 2 * Math.PI * radius;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину радиуса окружности");

            double rad;

            if (!double.TryParse(Console.ReadLine(), out rad) || rad <= 0)
            {
                Console.WriteLine("Error!");
                return;
            }

            double square = Math.Round(Square(rad), 2);
            double length = Math.Round(Length(rad), 2);

            Console.WriteLine($"Площадь = {square}, Длина окружности = {length}");
        }
    }
}
