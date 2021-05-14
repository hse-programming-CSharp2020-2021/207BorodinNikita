using System;
using System.IO;
using System.Linq;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Часть 1.
            using (var writer = new BinaryWriter(new FileStream("../../../Numbers", FileMode.Create)))
            {
                Random random = new Random();

                for (int i = 0; i < 10; i++)
                    writer.Write(random.Next(1, 101));
            }

            // Часть 2.
            using (var stream = new FileStream("../../../Numbers", FileMode.Open))
            {
                using (var writer = new BinaryWriter(stream))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        int value = Convert.ToInt32(Console.ReadLine());

                        if (value < 1 || value > 100)
                            return;

                        int[] array = new int[10];

                        for (int index = 0; index < array.Length; index++)
                            array[index] = reader.ReadInt32();

                        Array.ConvertAll(array, item => Math.Abs(item - value));
                        int idx = Array.FindIndex(array, item => item == array.Min());

                        writer.BaseStream.Seek(idx * 4, SeekOrigin.Begin);

                        writer.Write(value);
                    }
                }
            }

            using (var reader = new BinaryReader(new FileStream("../../../Numbers", FileMode.Open)))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                    Console.WriteLine(reader.ReadInt32());
            }
        }
    }
}
