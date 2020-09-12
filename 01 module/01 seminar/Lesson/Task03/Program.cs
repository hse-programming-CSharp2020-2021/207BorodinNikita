using System;


namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свою фамилию");

            string surname = Console.ReadLine();

            Console.WriteLine("Введите своё имя");

            string name = Console.ReadLine();

            Console.WriteLine("Введите своё отчество (при наличии)");

            string lastname = Console.ReadLine();

            Console.WriteLine("Фамилия: " + surname);

            Console.WriteLine("Имя: " + name);

            Console.WriteLine("Отчество: " + lastname);
        }
    }
}
