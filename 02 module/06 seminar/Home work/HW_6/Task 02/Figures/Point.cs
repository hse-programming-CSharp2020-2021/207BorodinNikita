using System;

namespace Figures
{
    public class Point
    {
        public double x;
        public double y;
        public virtual double Area
        {
            get { return 0; }
        }

        public virtual void Display()
        {
            Console.WriteLine($"Object type: point; coordinates: ({x:f3};{y:f3}); area = {Area:f3};");
        }
    }
}
