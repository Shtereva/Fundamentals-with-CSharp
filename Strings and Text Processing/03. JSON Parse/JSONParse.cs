using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.JSON_Parse
{
    public class Students
    {
        public string Name { get; set; }

        public string Age { get; set; }

        public List<string> Grades { get; set; }

        public static Students Read(ref string input)
        {
            int index = input.IndexOf("}");
            string student = input.Substring(0, index + 1).Trim('{', '}');

            int indexOfGrades = student.IndexOf('[');
            var grades = student.Substring(indexOfGrades).Trim('[', ']')
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var nameAndAge = student.Substring(0, indexOfGrades - 1).Split(',');
            string name = nameAndAge[0].Trim();
            string age = nameAndAge[1].Trim();

            if (index + 2 > input.Length)
            {
                input = string.Empty;
            }

            else
            {
                input = input.Substring(index + 2);
            }

            return new Students
            {
                Name = name,
                Age = age,
                Grades = new List<string>(grades)
            };
        }

        public override string ToString()
        {
            return Grades.Count > 0 ? $"{Name} : {Age} -> {string.Join(", ", Grades)}" : $"{Name} : {Age} -> None";
        }
    }

    public class JSONSParse
    {
        static void Main()
        {
            var students = new StringBuilder();
            var input = Console.ReadLine()
                .Trim('[', ']')
                .Replace("name:", "")
                .Replace("age:", "")
                .Replace("grades:", "")
                .Replace("\"", "");

            while (input.Length > 0)
            {
                var student = Students.Read(ref input);
                students.AppendLine(student.ToString());
            }

            Console.WriteLine(students.ToString());
        }
    }
}
