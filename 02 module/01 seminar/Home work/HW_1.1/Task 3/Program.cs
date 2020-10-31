using System;

namespace Task_3
{
    class Polygon
    {
        private int sidesNumber;
        private double radius;

        public double  Perimeter
        {
            get
            {
                return 2 * sidesNumber * radius * Math.Sin(Math.PI / sidesNumber);
            }
        }

        public double Area
        {
            get
            {
                return 0.5 * Perimeter * radius;
            }
        }

        public Polygon(int sidesNumber, double radius)
        {
            if (sidesNumber < 3)
            {
                throw new ArgumentException($"\nIncorrect number of the polygon's sides. Min value must be at least 3. Now: {sidesNumber}.\n");
            }
            this.sidesNumber = sidesNumber;

            if (radius <= 0)
            {
                throw new ArgumentException($"\nIncorrect number of the polygon's sides. Min value must be more than 0. Now: {radius}.\n");
            }
            this.radius = radius;
        }

        public void PolygonData()
        {
            Console.WriteLine($"\nFields:\n\tThe number of sides: {sidesNumber}\n\tThe value of the radius: {radius}\n");
            Console.WriteLine($"Properties:\n\tPerimeter value: {Perimeter}\n\tArea value: {Area}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.WriteLine($"Enter the count of the sides:");
                if (!int.TryParse(Console.ReadLine(), out int sidesNumber))
                {
                    Console.WriteLine("\nIncorrect input\n");
                    return;
                }

                Console.WriteLine($"\nEnter the value of the radius:");
                if (!double.TryParse(Console.ReadLine(), out double radius))
                {
                    Console.WriteLine("\nIncorrect input\n");
                    return;
                }

                try
                {
                    Polygon polygon = new Polygon(sidesNumber, radius);
                    polygon.PolygonData();
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }

                Console.WriteLine("To exit the program press \"Escape\"");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
