using System;

namespace Task_11
{
    class GeometricProgression
    {
        private double _start;
        private double _increment;

        public GeometricProgression(double start, double increment)
        {
            _start = start;
            _increment = increment;
        }

        public GeometricProgression() : this(1, 0) { }

        public double this[int index]
        {
            get
            {
                return Math.Pow(_increment, index - 1) * _start;
            }
        }

        public override string ToString()
        {
            return $"First element of the progression: {_start}; An increment: {_increment};";
        }

        public double Sum(int n)
        {
            return _start * (1 - Math.Pow(_increment, n)) / (1 - _increment);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            do
            {
                Console.Clear();

                Console.Write("Enter the value of the first element: ");

                if (!int.TryParse(Console.ReadLine(), out int start))
                {
                    Console.WriteLine("Incorrect input.");
                    continue;
                }

                Console.Write("Enter the value of the increment of the progression: ");

                if (!int.TryParse(Console.ReadLine(), out int increment))
                {
                    Console.WriteLine("Incorrect input.");
                    continue;
                }

                GeometricProgression progression = new GeometricProgression(start, increment);

                GeometricProgression[] progressions = new GeometricProgression[random.Next(5, 16)];

                for (int item = 0; item < progressions.Length; item++)
                {
                    progressions[item] =
                        new GeometricProgression(random.Next(0, 10) + random.NextDouble(), random.Next(0, 4) + random.NextDouble());
                }

                int step = random.Next(3, 16);

                foreach (var item in progressions)
                {
                    if (item[step] > progression[step])
                        Console.WriteLine($"\n{item}");
                }

                Console.WriteLine($"\nThe sum of first {step} elements of the each progression:\n");

                for (int i = 0; i < progressions.Length; i++)
                {
                    Console.WriteLine($"Progression №{i + 1}: {progressions[i]}{Environment.NewLine}Sum = {progressions[i].Sum(step)}\n");
                }

                Console.WriteLine("\nPress Esc to exit or another key to continue");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}