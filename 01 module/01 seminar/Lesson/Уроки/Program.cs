using System;


namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число №1");

            int first_value; bool check1 = int.TryParse(Console.ReadLine(), out first_value);

            Console.WriteLine("Введите число №2");

            int second_value; bool check2 = int.TryParse(Console.ReadLine(), out second_value);

            int result = first_value + second_value;

            if (check1 && check2)
            {
                Console.WriteLine("Результат сложения: " + result);
            }
            else
            {
                Console.WriteLine("Ошибка!");
            }
        }
    }
}
