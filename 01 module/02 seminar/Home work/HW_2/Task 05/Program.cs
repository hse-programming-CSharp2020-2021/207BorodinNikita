using System;

namespace Task_05
{
    class Program
    {
        static string Triangle(double AB, double BC, double CA)
        {
            string bad_result = "Треугольник не существует";

            string result = AB + BC > CA ? (BC + CA > AB ? (CA + AB > BC ? "Треугольник существует" : bad_result) : bad_result) : bad_result;

            return AB > 0 && BC > 0 && CA > 0 ? result : bad_result;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите длины всех сторон треугольника через пробел");

                string[] input = Console.ReadLine().Split();

                double AB = Math.Round(double.Parse(input[0]), 3);

                double BC = Math.Round(double.Parse(input[1]), 3);

                double CA = Math.Round(double.Parse(input[2]), 3);

                Console.WriteLine(Triangle(AB, BC, CA));

                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка!");
            }
        }
    }
}
