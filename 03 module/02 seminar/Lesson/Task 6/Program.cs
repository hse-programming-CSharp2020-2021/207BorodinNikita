using System;

namespace Task_6
{

    public class Plant
    {
        private double growth;
        private double photosensivity;
        private double frostresistance;

        public double Growth
        {
            get
            {
                return growth;
            }
            set
            {
                if (growth < 25 || growth > 100)
                    throw new ArgumentException("Incorrect growth.");

                else growth = value;
            }
        }
        public double Photosensivity
        {
            get
            {
                return photosensivity;
            }
            set
            {
                if (photosensivity < 0 || photosensivity > 100)
                    throw new ArgumentException("Incorrect photosensivity.");

                else photosensivity = value;
            }
        }

        public double Frostresistance
        {
            get
            {
                return frostresistance;
            }
            set
            {
                if (frostresistance < 0 || frostresistance > 80)
                    throw new ArgumentException("Incorrect frostresistance.");

                else frostresistance = value;
            }
        }

        public Plant(double growth, double photosensivity, double frostresistance)
        {
            this.growth = growth;
            this.photosensivity = photosensivity;
            this.frostresistance = frostresistance;
        }

        public override string ToString()
        {
            return $"Growth: {Growth}; Photosensivity: {Photosensivity}; Frostresistance: {Frostresistance}";
        }
    }
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.Write("Enter a count of plants: ");

            if (!uint.TryParse(Console.ReadLine(), out uint n))
                throw new ArgumentException("Incorrect input");

            Plant[] plants = new Plant[n];

            for (int i = 0; i < plants.Length; i++)
            {
                plants[i] = new Plant(random.Next(25, 100) + random.NextDouble(),
                    random.Next(0, 100) + random.NextDouble(),
                    random.Next(0, 80) + random.NextDouble());
            }

            Array.ForEach(plants, plant => Console.WriteLine(plant));
            Console.WriteLine();

            Array.Sort(plants, (plant1, plant2) =>
            {
                if (plant1.Growth < plant2.Growth)
                    return -1;

                else if (plant1.Growth == plant2.Growth)
                    return 0;

                else return 1;
            }
            );
            Array.ForEach(plants, plant => Console.WriteLine(plant));
            Console.WriteLine();

            Array.Sort(plants, (plant1, plant2) =>
            {
                if (plant1.Frostresistance > plant2.Frostresistance)
                    return -1;

                else if (plant1.Growth == plant2.Growth)
                    return 0;

                else return 1;
            }
            );
            Array.ForEach(plants, plant => Console.WriteLine(plant));
            Console.WriteLine();

            Array.Sort(plants, (plant1, plant2) =>
            {
                if (plant1.Photosensivity % 2 < plant2.Photosensivity % 2)
                    return -1;

                else if (plant1.Photosensivity % 2 == plant2.Photosensivity % 2)
                    return 0;

                else return 1;
            }
            );
            Array.ForEach(plants, plant => Console.WriteLine(plant));
            Console.WriteLine();

            plants = Array.ConvertAll(plants, plant => new Plant(plant.Growth, plant.Photosensivity, plant.Frostresistance % 2 == 0 ? plant.Frostresistance / 3 : plant.Frostresistance / 2));
            Array.ForEach(plants, plant => Console.WriteLine(plant));
        }
    }
}
