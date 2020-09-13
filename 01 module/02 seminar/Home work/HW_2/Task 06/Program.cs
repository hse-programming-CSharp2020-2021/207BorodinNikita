using System;
using System.Globalization;

namespace Task_06
{
    class Program
    {
        static CultureInfo ci = new CultureInfo("ru-us");
        static void Percent(double budget, byte part)
        {
            Console.WriteLine("Доля, выделенная пользователем на компьютерные игры: {0}", (budget * part / 100).ToString("C", ci));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите бюджет пользователя в долларах");

            if (!double.TryParse(Console.ReadLine(), out double budget) || budget < 0)
            {
                Console.WriteLine("Ошибка!");
                return;
            }

            Console.WriteLine("Введите процент бюджета, выделенного на компьютерные игры");

            if (!byte.TryParse(Console.ReadLine(), out byte part) || part > 100)
            {
                Console.WriteLine("Ошибка!");
                return;
            }

            Percent(budget, part);

            Console.ReadLine();
        }
    }
}
