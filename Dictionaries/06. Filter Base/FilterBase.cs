using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Filter_Base
{
    class FilterBase
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var employeeAge = new Dictionary<string, int>();
            var employeeSalary = new Dictionary<string, double>();
            var employeePossition = new Dictionary<string, string>();

            while (input[0] != "filter")
            {
                StoringEmployeesData(input, employeeAge, employeeSalary, employeePossition);

                input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            PrintEmployeeData(input, employeeAge, employeeSalary, employeePossition);
        }

        private static void PrintEmployeeData(string[] input, Dictionary<string, int> employeeAge, Dictionary<string, double> employeeSalary, Dictionary<string, string> employeePossition)
        {
            if (input[0] == "Position")
            {
                foreach (var kvp in employeePossition)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Position: {kvp.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }

            else if (input[0] == "Salary")
            {
                foreach (var kvp in employeeSalary)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Salary: {kvp.Value:f2}");
                    Console.WriteLine(new string('=', 20));
                }
            }

            else
            {
                foreach (var kvp in employeeAge)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Age: {kvp.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }

        private static void StoringEmployeesData(string[] input, Dictionary<string, int> employeeAge, Dictionary<string, double> employeeSalary, Dictionary<string, string> employeePossition)
        {
            int number = 0;
            bool isNumber = int.TryParse(input[1], out number);

            double floatNumber = 0.0;
            bool isDouble = double.TryParse(input[1], out floatNumber);

            if (isNumber)
            {
                employeeAge.Add(input[0], number);
            }

            else if (isDouble && isNumber == false)
            {
                employeeSalary.Add(input[0], floatNumber);
            }

            else
            {
                employeePossition.Add(input[0], input[1]);
            }
        }
    }
}
