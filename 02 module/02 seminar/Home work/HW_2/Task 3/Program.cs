using System;
using System.Linq;

namespace Task_3
{
    class Polygon
    {
        private int sidesNumber;
        private double radius;

        public double Perimeter
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
                throw new ArgumentException($"\nIncorrect value of the radius. Min value must be more than 0. Now: {radius}.\n");
            }
            this.radius = radius;
        }

        public void PolygonData(ConsoleColor color = ConsoleColor.Gray)
        {
            Console.WriteLine($"Fields:\n\tThe number of sides: {sidesNumber}\n\tThe value of the radius: {radius}\n");
            Console.Write($"Properties:\n\tPerimeter value: {Perimeter}\n\tArea value: ");

            Console.ForegroundColor = color;

            Console.WriteLine($"{Area}\n");

            Console.ResetColor();
        }
    }
    class Program
    {
        static void Add(ref Polygon[] polygons, Polygon newPolygon)
        {
            Array.Resize(ref polygons, polygons.Length + 1);

            polygons[polygons.Length - 1] = newPolygon;
        }

        static void Add(ref double[] areas, Polygon newPolygon)
        {
            Array.Resize(ref areas, areas.Length + 1);

            areas[areas.Length - 1] = newPolygon.Area;
        }
        static void Main(string[] args)
        {
            Polygon[] polygons = new Polygon[0];

            double[] areas = new double[0];

            do
            {
                for (int i = 0; i < polygons.Length; i++)
                {
                    if (areas[i] == areas.Min()) { polygons[i].PolygonData(ConsoleColor.Green); continue; }

                    if (areas[i] == areas.Max()) { polygons[i].PolygonData(ConsoleColor.Red); continue; }

                    polygons[i].PolygonData();
                }

                Console.WriteLine($"Enter the count of the sides of the new polygon:");
                if (!int.TryParse(Console.ReadLine(), out int sidesNumber))
                {
                    Console.WriteLine("\nIncorrect input\n");
                    return;
                }

                Console.WriteLine($"\nEnter the value of the radius of the new polygon:");
                if (!double.TryParse(Console.ReadLine(), out double radius))
                {
                    Console.WriteLine("\nIncorrect input\n");
                    return;
                }

                if (sidesNumber == 0 && radius == 0)
                {
                    return;
                }

                try
                {
                    Polygon newPolygon = new Polygon(sidesNumber, radius);

                    Add(ref polygons, newPolygon);

                    Add(ref areas, newPolygon);
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);

                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }

                Console.Clear();

            } while (true);
        }
    }
}
