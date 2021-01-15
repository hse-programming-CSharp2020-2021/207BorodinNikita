using System;
using Kumir;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            Steps trace = delegate () { };

            uint length;

            while (true)
            {
                Console.Write("Enter the length of the work field (odd natural number): ");

                if (!uint.TryParse(Console.ReadLine(), out length) || length % 2 != 1)
                    Console.WriteLine("Incorrect input. Try again.\n");

                else break;
            }
            Console.WriteLine();

            char[,] field = new char[length, length];

            (int x, int y) = ((int)(0.5 * length), (int)(0.5 * length));

            for (int row = 0; row < length; row++)
            {
                for (int column = 0; column < length; column++)
                {
                    field[row, column] = '*';

                    if(row == y && column == x)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"\t{field[row, column]}");

                        Console.ResetColor();
                    }
                    else 
                        Console.Write($"\t{field[row, column]}");
                }

                Console.Write("\n\n");
            }

            do
            {
                Console.WriteLine("\nPlease, write the commands sequence for your robot:");
                string S = Console.ReadLine();
                Console.WriteLine();

                try
                {
                    foreach (var letter in S)
                    {
                        field[y, x] = '+';

                        switch (letter)
                        {
                            case 'R':
                                trace += robot.Right;
                                if (++x >= length)
                                    throw new IndexOutOfRangeException();

                                break;

                            case 'L':
                                trace += robot.Left;
                                if (--x < 0)
                                    throw new IndexOutOfRangeException();

                                break;

                            case 'F':
                                trace += robot.Forward;
                                if (--y < 0)
                                    throw new IndexOutOfRangeException();

                                break;

                            case 'B':
                                trace += robot.Backward;
                                if (++y >= length)
                                    throw new IndexOutOfRangeException();

                                break;

                            default:
                                Console.WriteLine($"Unrecognized command \"{letter}\"");

                                field[x, y] = '*';

                                break;
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine($"\nThe robot was caught on trying to get beyond the field and enslave humanity.{Environment.NewLine}" +
                        "Program was stopped, robot was terminated.");

                    Console.ResetColor();

                    return;
                }

                trace?.Invoke();

                for (int row = 0; row < length; row++)
                {
                    for (int column = 0; column < length; column++)
                    {
                        if (row == y && column == x)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"\t{field[row, column]}");

                            Console.ResetColor();
                        }
                        else
                            Console.Write($"\t{field[row, column]}");
                    }

                    Console.Write("\n\n");
                }
            } while (true);
        }
    }
}
