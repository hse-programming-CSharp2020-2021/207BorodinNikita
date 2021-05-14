using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public class GeomProgr
    {
        
        public static uint objectNumber = 0;
        double _b; 
        double _q; 
        public double B
        {
            get { return _b; }
            set
            {
                if (value == 0) throw new ArgumentException("Incorrect value for the first member of the progression.");
                _b = value;
            }
        }
        public double Q
        {
            get { return _q; }
            set
            {
                if (value == 0) throw new ArgumentException("Incorrect value for the denominator of the progression.");
                _q = value;
            }
        }

        public GeomProgr()
        {
            _b = 1;
            _q = 1;
            objectNumber++;
            Console.WriteLine(objectNumber + ": Constructor without parameters");
        }

        public GeomProgr(double b, double q) : this()
        {
            if (b == 0 || q == 0)
            {
                objectNumber--;
                throw new ArgumentException("Incorrect arguments.");
            }
            _b = b;
            _q = q;
            Console.WriteLine(objectNumber + ": Constructor with parameters");
        }

        public double this[int n]
        {
            get
            {
                if (n < 0) throw new IndexOutOfRangeException("The index must be greater than or equal to zero.");
                return _b * Math.Pow(_q, n);
            }
        }

        public double ProgrSum(int n)
        {
            if (n < 0) throw new ArgumentException("The number of members cannot be negative.");
            return _b * (Math.Pow(_q, n + 1) - 1) / (_q - 1);
        }
    }
}