using System;

namespace Task_7
{
    class Program
    {
        static void Sum(object[,] data)
        {
            int sum = 0;

            foreach (var item in data)
            {
                if (item.GetType() == 0.GetType())
                {
                    sum += (int)item;
                }
            }

            Console.WriteLine($"All sailed cars by this year: {sum}\n");
        }

        static void Statistics(object[,] data)
        {
            for (int branch = 1; branch < data.GetLength(1); branch++)
            {
                for (int quarter = 1, bestQuarter = 1, maxCount = (int)data[quarter, branch]; quarter < data.GetLength(0) - 1; quarter++)
                {
                    if ((int)data[quarter, branch] < (int)data[quarter + 1, branch])
                    {
                        bestQuarter = quarter + 1;
                        maxCount = (int)data[quarter + 1, branch];
                    }

                    if (quarter == data.GetLength(0) - 2)
                    {
                        Console.WriteLine($"Branch name: {data[0, branch]}{Environment.NewLine}The most sucessful quarter: {data[bestQuarter, 0]}");
                        Console.WriteLine($"The count of cars selled during this quarter: {maxCount}{Environment.NewLine}");
                    }
                }
            }
        }

        static void BestBranch(object[,] data)
        {
            int bestBranch = 1, maxSum = 0;

            for (int branch = 1; branch < data.GetLength(1); branch++)
            {
                int branchSum = 0;

                for (int quarter = 1; quarter < data.GetLength(0); quarter++)
                {
                    branchSum += (int)data[quarter, branch];
                }

                if (branchSum > maxSum)
                {
                    bestBranch = branch;
                    maxSum = branchSum;
                }
            }

            Console.WriteLine($"The most profitable branch: {data[0, bestBranch]}" +
                $"{Environment.NewLine}The count of cars selled during this year by this branch: {maxSum}{Environment.NewLine}");
        }

        static void BestQuarter(object[,] data)
        {
            int bestQuarter = 1, maxSum = 0;

            for (int quarter = 1; quarter < data.GetLength(0); quarter++)
            {
                int quarterSum = 0;

                for (int branch = 1; branch < data.GetLength(1); branch++)
                {
                    quarterSum += (int)data[quarter, branch];
                }

                if (quarterSum > maxSum)
                {
                    bestQuarter = quarter;
                    maxSum = quarterSum;
                }
            }

            Console.WriteLine($"The most profitable quarter: {data[bestQuarter, 0]}" +
                $"{Environment.NewLine}The count of cars selled during this quarter by the all of branches: {maxSum}{Environment.NewLine}");
        }
        static void Main(string[] args)
        {
            object[,] data =
            {
                {"Квартал \\ Филиал", "Западный", "Центральный", "Восточный"},
                {"I", 20, 24, 25},
                {"II", 21, 20, 18},
                {"III", 23, 27, 24},
                {"IV", 22, 19, 20}
            };

            Sum(data);

            Statistics(data);

            BestBranch(data);

            BestQuarter(data);
        }
    }
}
