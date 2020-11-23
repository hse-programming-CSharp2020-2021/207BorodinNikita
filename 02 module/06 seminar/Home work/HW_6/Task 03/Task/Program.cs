using System;
using System.Collections.Generic;
using Organization;

namespace Task_3
{
    class Program
    {
        static Random random = new Random();

        static string RandomName()
        {
            string name = string.Empty;

            for (int iterator = 0; iterator < random.Next(3, 11); iterator++)
            {
                if (iterator == 0)
                    name += (char)random.Next('A', 'Z');
                else
                    name += (char)random.Next('a', 'z');
            }

            return name;
        }

        static void Main(string[] args)
        {
            Employee[] employees = new Employee[random.Next(10, 21)];

            for (int index = 0; index < employees.Length; index++)
            {
                if (random.Next(0, 2) == 0)
                    employees[index] = new SalesEmployee(RandomName(),
                        (decimal)(random.Next(100, 5000) + random.NextDouble()), (decimal)(random.Next(0, 500) + random.NextDouble()));
                else
                    employees[index] = new PartTimeEmployee(RandomName(),
                           (decimal)(random.Next(100, 5000) + random.NextDouble()), random.Next(0, 31));
            }

            List<SalesEmployee> salesEmployees = new List<SalesEmployee>();
            List<PartTimeEmployee> partTimeEmployees = new List<PartTimeEmployee>();

            foreach (var employee in employees)
            {
                if (employee is SalesEmployee)
                    salesEmployees.Add((SalesEmployee)employee);
                else
                    partTimeEmployees.Add((PartTimeEmployee)employee);
            }

            Console.WriteLine("Base array of sales employees:\n");

            foreach (var employee in salesEmployees)
            {
                Console.WriteLine($"\tName: {employee.name}; pay = {employee.CalculatePay()}");
            }

            SalesEmployee[] salesEmployeesArray = salesEmployees.ToArray();

            Array.Sort(salesEmployeesArray, (item1, item2) => item1.CalculatePay().CompareTo(item2.CalculatePay()));
            Array.Reverse(salesEmployeesArray);

            Console.WriteLine("\nSorted array of sales employees:\n");

            foreach (var employee in salesEmployeesArray)
            {
                Console.WriteLine($"\tName: {employee.name}; pay = {employee.CalculatePay()}");
            }

            Console.WriteLine("\nBase array of part time employees:\n");

            foreach (var employee in partTimeEmployees)
            {
                Console.WriteLine($"\tName: {employee.name}; pay = {employee.CalculatePay()}");
            }

            PartTimeEmployee[] partTimeEmployeesArray = partTimeEmployees.ToArray();

            Array.Sort(partTimeEmployeesArray, (item1, item2) => item1.CalculatePay().CompareTo(item2.CalculatePay()));
            Array.Reverse(partTimeEmployeesArray);

            Console.WriteLine("\nSorted array of part time employees:\n");

            foreach (var employee in partTimeEmployeesArray)
            {
                Console.WriteLine($"\tName: {employee.name}; pay = {employee.CalculatePay()}");
            }
        }
    }
}
