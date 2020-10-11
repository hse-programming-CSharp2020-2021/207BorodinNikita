using System;
using System.IO;

class Program
{
    public const string outputPath = "output.txt";
    static void Main()
    {
        Generator generator = new Generator();

        generator.Generate();

        string[] A = File.ReadAllText(Generator.inputPath).Trim().Split();

        bool[] L = new bool[A.Length];

        File.WriteAllText(outputPath, string.Empty);

        StreamWriter streamWriter = new StreamWriter(outputPath);

        for (int i = 0; i < L.Length; i++)
        {
            L[i] = Convert.ToInt32(A[i]) >= 0 ? true : false;

            streamWriter.Write($"{L[i]} ");
        }

        streamWriter.Close();
    }    
}