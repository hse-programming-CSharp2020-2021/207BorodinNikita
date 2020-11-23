using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Square : Point
    {
        private double side;
        public double Side
        {
            get { return side; }
        }

        public double Len
        {
            get { return 4 * Side; }
        }

        public override double Area
        {
            get { return Side * Side; }
        }

        public Square(double x, double y, double side)
        {
            this.x = x;
            this.y = y;

            this.side = side;
        }

        public override void Display()
        {
            Console.WriteLine($"Object type: square; center coordinates: ({x:f3};{y:f3}); side = {Side:f3}; area = {Area:f3}; length = {Len:f3};");
        }
    }
}
