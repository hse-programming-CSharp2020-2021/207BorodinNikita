using System;
using System.IO;

namespace Task_2
{
    class Program
    {
        public const string outputPath = "output.txt";
        static void Main(string[] args)
        {
            Generator generator = new Generator();

            generator.Generate();

            string[] A = File.ReadAllText(Generator.inputPath).Trim().Split();

            File.WriteAllText(outputPath, string.Empty);

            StreamWriter streamWriter = new StreamWriter(outputPath);

            int[] B = new int[A.Length];

            for (int i = 0; i < B.Length; i++)
            {
                int addToB, degree = 0;
                do
                {
                    addToB = 2 << degree;
                    degree++;

                } while (addToB * 2 < Convert.ToInt32(A[i]));

                B[i] = addToB;

                streamWriter.Write($"{B[i]} ");
            }

            streamWriter.Close();
        }
    }
}
