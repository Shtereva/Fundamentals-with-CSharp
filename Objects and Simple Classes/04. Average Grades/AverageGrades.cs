using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Average_Grades
{
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrade => Grades.Average();
    }

    public class AverageGrades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                string name = line[0];
                var grades = line.Skip(1).Select(double.Parse).ToList();
                AddGrades(students, name, grades);
            }

            students
                .Where(x => x.AverageGrade >= 5.00)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Name} -> {x.AverageGrade:f2}"));
        }

        private static void AddGrades(List<Student> students, string name, List<double> grades)
        {
            
                students.Add(new Student()
                {
                    Name = name,
                    Grades = grades.ToList()
                });
        }
    }
}
