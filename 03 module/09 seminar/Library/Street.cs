using System;
using System.Text;

namespace Library
{
    public class Street
    {
        private string name;

        private int[] houses;

        public string Name 
        {
            get { return name; } 
        }

        public int[] Houses
        {
            get { return houses; }
        }

        public Street(string name, params int[] houses)
        {
            this.name = name;
            this.houses = houses;
        }
        public static int operator ~(Street street)
        {
            return street.Houses.Length;
        }

        public static bool operator !(Street street)
        {
            foreach (var house in street.Houses)
            {
                foreach (var number in house.ToString())
                {
                    if (number == '7')
                        return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            string newLine = Environment.NewLine;
            StringBuilder info = new StringBuilder($"{Name} ");

            info.AppendJoin(' ', Houses);

            return info.ToString();
        }
    }
}
