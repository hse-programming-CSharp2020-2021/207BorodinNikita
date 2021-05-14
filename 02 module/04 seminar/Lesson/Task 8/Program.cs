using System;
using System.Linq;

namespace Task_8
{
    class Point
    {
        private double x;
        private double y;
        private double z;

        public double X
        {
            get { return x; }
        }
        public double Y
        {
            get { return y; }
        }
        public double Z
        {
            get { return z; }
        }

        public static double Length(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2) + Math.Pow(A.Z - B.Z, 2));
        }

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public string Coordinates()
        {
            return $"({X};{Y};{Z})";
        }
    }
    class Triangle
    {
        private Point A;
        private Point B;
        private Point C;

        public double Perimeter
        {
            get
            {
                return Point.Length(A, B) + Point.Length(B, C) + Point.Length(A, C);
            }
        }
        public double Square
        {
            get
            {
                double p = Perimeter * 0.5;
                return Math.Sqrt(p * (p - Point.Length(A, B)) * (p - Point.Length(A, C)) * (p - Point.Length(B, C)));
            }
        }
        public Triangle()
        {
            A = new Point(0, 0, 0);
            B = new Point(2, 0, 0);
            C = new Point(1, 1, 0);
        }

        public Triangle(Point A, Point B, Point C)
        {
            if (Point.Length(A, B) + Point.Length(B, C) <= Point.Length(A, C))
            {
                throw new Exception();
            }
            if (Point.Length(A, B) + Point.Length(A, C) <= Point.Length(B, C))
            {
                throw new Exception();
            }
            if (Point.Length(A, C) + Point.Length(B, C) <= Point.Length(A, B))
            {
                throw new Exception();
            }

            this.A = A;
            this.B = B;
            this.C = C;
        }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
            :this(new Point(x1, y1, 0), new Point(x2, y2, 0), new Point(x3, y3, 0)){ }

        public void GetInfo()
        {
            Console.WriteLine($"Coordinates:\nA = {A.Coordinates()}\nB = {B.Coordinates()}\nC = {C.Coordinates()}\n");
            Console.WriteLine($"Perimeter = {Math.Round(Perimeter, 3)}");
            Console.WriteLine($"Square = {Math.Round(Square, 3)}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Random random = new Random();
                Triangle[] triangles = new Triangle[random.Next(5, 16)];

                for (int i = 0; i < triangles.Length; i++)
                {
                    Point A = new Point(random.Next(-10, 11), random.Next(-10, 11), random.Next(-10, 11));
                    Point B = new Point(random.Next(-10, 11), random.Next(-10, 11), random.Next(-10, 11));
                    Point C = new Point(random.Next(-10, 11), random.Next(-10, 11), random.Next(-10, 11));

                    try
                    {
                        triangles[i] = new Triangle(A, B, C);
                    }
                    catch (Exception)
                    {
                        triangles[i] = new Triangle();
                    }

                    Console.WriteLine($"\tTriangle №{i + 1}:");
                    triangles[i].GetInfo();
                }

                Triangle[] sortedTriangles = triangles.OrderByDescending(i => i.Square).ToArray();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sort is completed\n");
                Console.ResetColor();

                for (int i = 0; i < sortedTriangles.Length; i++)
                {
                    Console.WriteLine($"\tTriangle №{i + 1}:");
                    sortedTriangles[i].GetInfo();
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Press \"Esc\" to exit the program.");
                Console.ResetColor();

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
