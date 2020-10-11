using System;
using System.IO;

class Generator
{
    public const string inputPath = "input.txt";
    public void Generate()
    {
        Random random = new Random();

        File.WriteAllText(inputPath, string.Empty);

        StreamWriter streamWriter = new StreamWriter(inputPath);

        for (int i = 0; i < random.Next(1, 101); i++)
        {
            streamWriter.Write($"{random.Next(0, 10001)} ");
        }

        streamWriter.Close();
    }
}