using System;
using System.IO;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter(new FileStream("../../../Values.txt", FileMode.Create)))
            {
                Random random = new Random();

                for (int iterator = 1; iterator <= 100; iterator++)
                    writer.WriteLine(random.Next(100, 999) + random.NextDouble());
            }

            using (var reader = new StreamReader(new FileStream("../../../Values.txt", FileMode.Open)))
            {
                Console.SetIn(reader);

                double sum = new double();
                int amount = new int();

                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    sum += Convert.ToDouble(Console.ReadLine());
                    amount++;
                }

                Console.WriteLine(sum /= amount);
                Console.SetIn(new StreamReader(Console.OpenStandardInput()));
            }
        }
    }
}
