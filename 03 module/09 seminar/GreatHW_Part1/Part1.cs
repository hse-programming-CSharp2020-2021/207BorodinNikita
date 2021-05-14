using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Library;

namespace GreatHW
{
    class Part1
    {
        static void Main(string[] args)
        {
            if (!int.TryParse(Console.ReadLine(), out int N))
            {
                Console.WriteLine("Incorrect input.");
                return;
            }

            Street[] streetsArray = new Street[N];

            try
            {
                using (StreamReader reader = new StreamReader("data.txt"))
                {
                    List<Street> streets = new List<Street>();

                    while (!reader.EndOfStream)
                    {
                        if (TryParseStreet(reader.ReadLine(), out Street street))
                            streets.Add(street);

                        else throw new ArgumentException();
                    }

                    if (streets.Count < N)
                        Array.Resize(ref streetsArray, streetsArray.Length);

                    for (int index = 0; index < streetsArray.Length; index++)
                        streetsArray[index] = streets[index];
                }
            }
            catch(IOException)
            {
                Console.WriteLine($"Impossible to open \"data.txt\". Houses and streets will be constructed randomly.{Environment.NewLine}");
                DefaultGeneration(streetsArray);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"File \"data.txt\" was damaged. Houses and streets will be constructed randomly.{Environment.NewLine}");
                DefaultGeneration(streetsArray);
            }

            using (StreamWriter writer = new StreamWriter(new FileStream("out.txt", FileMode.Create)))
            {
                foreach (var street in streetsArray)
                {
                    Console.WriteLine(street);
                    writer.WriteLine(street);
                }
            }
        }

        static void DefaultGeneration(Street[] streetsArray)
        {
            Random random = new Random();

            for (int index = 0; index < streetsArray.Length; index++)
                streetsArray[index] = new Street(GenerateName(random), GenerateHouses(random));
        }

        static string GenerateName(Random random)
        {
            StringBuilder name = new StringBuilder();

            while(name.Length < random.Next(5, 11))
            {
                if (name.Length == 0)
                    name.Append((char)random.Next('A', 'Z'));

                else name.Append((char)random.Next('a', 'z'));
            }

            return name.ToString();
        }

        static int[] GenerateHouses(Random random)
        {
            int[] houses = new int[random.Next(1, 11)];

            for (int index = 0; index < houses.Length; index++)
                houses[index] = random.Next(1, 101);

            return houses;
        }

        static bool TryParseStreet(string line, out Street street)
        {
            string[] values = line.Split(' ');

            if (values.Length < 2)
            {
                street = null;
                return false;
            }

            string name = values[0];
            int[] houses = new int[values.Length - 1];

            for (int index = 1; index < values.Length; index++)
            {
                if (!int.TryParse(values[index], out houses[index - 1]))
                {
                    street = null;
                    return false;
                }
            }

            street = new Street(name, houses);
            return true;
        }
    }
}
