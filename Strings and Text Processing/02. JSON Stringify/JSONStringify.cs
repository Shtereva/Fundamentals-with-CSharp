using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.JSON_Stringify
{
    public class Students
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<int> Grades { get; set; }

        public static Students Read(string input)
        {
            var splitGrades = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var grades = new List<int>();
            if (splitGrades.Length > 1)
            {
                grades = splitGrades[1].Trim().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            }

            var splitNameAndAge = splitGrades[0].Trim().Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string name = splitNameAndAge[0].Trim();
            int age = int.Parse(splitNameAndAge[1].Trim());

            return new Students
            {
                Name = name,
                Age = age,
                Grades = new List<int>(grades) 
            };
        }

        public override string ToString()
        {
            return $"{{name:\"{Name}\",age:{Age},grades:[{string.Join(", ", Grades)}]}}";
        }
    }

    public class JSONStringify
    {
        static void Main()
        {
            var students = new List<Students>();
            var input = Console.ReadLine();

            while (input != "stringify")
            {

                var student = Students.Read(input);
                students.Add(student);

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(",", students)}]");
        }
    }
}
