using System;
using System.Linq;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = Array.ConvertAll(new int[Convert.ToInt32(Console.ReadLine())], i => random.Next(-10000, 10000));

            #region LINQ запросы.
            Console.WriteLine("\nLINQ Запросы");

            var query1 = from number in numbers select number % 10;

            Console.WriteLine("№1:");
            foreach (var item in query1)
                Console.WriteLine(item);

            var query2 = from number in numbers group number by number % 10;

            Console.WriteLine("\n№2:");
            foreach (var g in query2)
            {
                Console.WriteLine($"Key {g.Key}:");
                foreach (var item in g)
                    Console.WriteLine($"\t{item}");
            }


            var query3 = from number in numbers where number > 0 && number % 2 == 0 select number;

            Console.WriteLine("\n№3:");
            foreach (var item in query3)
                Console.WriteLine(item);
            Console.WriteLine($"Count: {query3.Count()}");

            var query4 = (from number in numbers where number % 2 == 0 select number).Sum();

            Console.WriteLine("\n№4:");
            Console.WriteLine($"Sum: {query4}");

            var query5 = from number in numbers
                         orderby Convert.ToInt32(Math.Abs(number).ToString()[0]), number % 10
                         select number;

            Console.WriteLine("\n№5:");
            foreach (var item in query5)
                Console.WriteLine(item);

            #endregion

            #region Методы расширения.
            Console.WriteLine("\nМетоды расширения");

            query1 = numbers.Select(i => i % 10);

            Console.WriteLine("№1:");
            foreach (var item in query1)
                Console.WriteLine(item);

            query2 = numbers.GroupBy(i => i % 10);

            Console.WriteLine("\n№2:");
            foreach (var g in query2)
            {
                Console.WriteLine($"Key {g.Key}:");
                foreach (var item in g)
                    Console.WriteLine($"\t{item}");
            }

            query3 = numbers.Where(i => i > 0 && i % 2 == 0);

            Console.WriteLine("\n№3:");
            foreach (var item in query3)
                Console.WriteLine(item);
            Console.WriteLine($"Count: {query3.Count()}");

            query4 = numbers.Where(i => i % 2 == 0).Sum();

            Console.WriteLine("\n№4:");
            Console.WriteLine($"Sum: {query4}");

            query5 = numbers.OrderBy(i => Convert.ToInt32(Math.Abs(i).ToString()[0])).ThenBy(i => i % 10);

            Console.WriteLine("\n№5:");
            foreach (var item in query5)
                Console.WriteLine(item);

            #endregion
        }
    }
}
