using System;

namespace Figures
{
    public class Circle : Point
    {
        private double rad;

        public double Rad
        {
            get { return rad; }
        }

        public double Len
        {
            get { return 2 * Math.PI * Rad; }
        }

        public Circle(double x, double y, double radius) : base()
        {
            this.x = x;
            this.y = y;

            rad = radius;
        }

        public override double Area
        {
            get { return Math.PI * Rad * Rad; }
            
        }

        public override void Display()
        {
            Console.WriteLine($"Object type: circle; center coordinates: ({x:f3};{y:f3}); rad = {Rad:f3}; area = {Area:f3}; length = {Len:f3};");
        }
    }
}
