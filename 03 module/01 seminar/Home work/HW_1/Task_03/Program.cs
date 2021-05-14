using System;

namespace Task_03
{
    class Program
    {
        delegate double delegateConvertTemperature(double input);

        static void Main(string[] args)
        {
            delegateConvertTemperature[] converters =
            {
                new TemperatureConverterImp().FromCelsToFahr,
                StaticTempConverters.FromCelsToKelv,
                StaticTempConverters.FromCelsToRa,
                StaticTempConverters.FromCelsToRe
            };

            double temperatureC = new Random().Next(-273, 1000) + new Random().NextDouble();

            Console.WriteLine("C\tF\tK\tRa\tR");

            Console.Write($"{temperatureC:F2}\t");

            foreach (var item in converters)
            {
                Console.Write($"{item.Invoke(temperatureC):F2}\t");
            }

            Console.WriteLine();
        }
    }
}
