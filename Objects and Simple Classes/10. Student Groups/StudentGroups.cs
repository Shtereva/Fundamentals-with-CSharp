using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace _10.Student_Groups
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }

        public static Student ReadStudent(string input)
        {
            var line = input.Split('|').Select(x => x.Trim()).ToArray();
            var date = DateTime.ParseExact(line[2], "d-MMM-yyyy", CultureInfo.InvariantCulture);

            return new Student
            {
                Name = line[0],
                Email = line[1],
                RegistrationDate = date
            };
        }
    }

    public class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }

        public static Town ReadTown(string input)
        {
            var line = input.Split("=>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            var digit = line[1].Split();
            return new Town
            {
                Name = line[0],
                SeatsCount = int.Parse(digit[0]),
                Students = new List<Student>()
            };
        }
    }

    public class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }

    public class StudentGroups
    {
        static void Main()
        {
            var towns = ReadTownAndStudents();

            var groups = DistributeStudentsIntoGroups(towns);

            Console.WriteLine($"Created {groups.Count} groups in {groups.Select(x => x.Town.Name).Distinct().Count()} towns:");

            foreach (var group in groups.OrderBy(x => x.Town.Name))
            {
                Console.WriteLine($"{group.Town.Name} => {string.Join(", ", group.Students.Select(x => x.Email))}");
            }
        }

        private static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (var town in towns.OrderBy(x => x.Name))
            {
                IEnumerable<Student> students = town.Students
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email);

                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }

            return groups;
        }

        private static List<Town> ReadTownAndStudents()
        {
            var towns = new List<Town>();
            string input = Console.ReadLine();
            string lastTown = string.Empty;

            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                        var town = Town.ReadTown(input);
                        lastTown = town.Name;
                        towns.Add(town);
                }

                else
                {
                    var students = Student.ReadStudent(input);
                    towns.Find(x => x.Name == lastTown).Students.Add(students);
                }

                input = Console.ReadLine();
            }

            return towns;
        }
    }

}
