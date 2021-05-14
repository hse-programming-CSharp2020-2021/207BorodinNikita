using System;

namespace Task_10
{
    class Circle
    {
        private int x;
        private int y;
        private int radius;

        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;

            this.radius = radius;
        }

        public Circle() : this(new Random().Next(1, 16), new Random().Next(1, 16), new Random().Next(1, 16)) { }

        public static bool Intersection(Circle circle1, Circle circle2)
        {
            double distance = Math.Sqrt(Math.Pow(circle1.x - circle2.x, 2) + Math.Pow(circle1.y - circle2.y, 2));

            return distance <= circle1.radius + circle2.radius;
        }
        public override string ToString()
        {
            return $"x = {x}; y = {y}; Radius = {radius};";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.Write("Enter the value of N: ");

                if (!uint.TryParse(Console.ReadLine(), out uint N))
                {
                    Console.WriteLine("Incorrect input");
                    continue;
                }

                Circle[] circles = new Circle[N];

                for (int index = 0; index < circles.Length; index++)
                {
                    Console.WriteLine();

                    circles[index] = new Circle();
                    Console.WriteLine(circles[index]);
                }

                Circle mainCircle = new Circle();

                Console.WriteLine($"\nAll circles that intersect with the main one ({mainCircle}):\n");

                foreach (var item in circles)
                {
                    if (Circle.Intersection(item, mainCircle))
                    {
                        Console.WriteLine($"{item}\n");
                    }
                }

                Console.WriteLine("\nPress Esc to exit or another key to continue");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}