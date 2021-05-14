using System;
using System.Collections.Generic;
using System.IO;
using Library;

namespace GreatHW_Part2
{
    class Part2
    {
        static void Main(string[] args)
        {
            Street[] streetsArray;

            using (StreamReader reader = 
                new StreamReader(Path.Combine("..", "..", "..", "..", "GreatHW_Part1", "bin", "Debug", "netcoreapp3.1", "out.txt")))
            {
                List<Street> streets = new List<Street>();

                while (!reader.EndOfStream)
                {
                    string[] input = reader.ReadLine().Split(' ');

                    string name = input[0];
                    int[] houses = Array.ConvertAll(input[1..], house => Convert.ToInt32(house));

                    streets.Add(new Street(name, houses));
                }

                streetsArray = streets.ToArray();
            }

            foreach (var street in streetsArray)
            {
                if(~street % 2 == 1 && !street)
                    Console.WriteLine(street);
            }
        }
    }
}
