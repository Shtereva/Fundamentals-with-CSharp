using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08.MentorGroup
{
    public class MentorGroup
    {
        public class Student
        {
            public List<string> Comments { get; set; }

            public List<DateTime> Dates { get; set; }
        }

        static void Main()
        {
            var mentorsGroup = new SortedDictionary<string, Student>();

            string input = Console.ReadLine();

            while (input != "end of dates")
            {
                AddStudentsToGroup(mentorsGroup, input);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end of comments")
            {
                var line = input.Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (!mentorsGroup.ContainsKey(line[0]))
                {
                    input = Console.ReadLine();
                    continue;
                }

                mentorsGroup[line[0]].Comments.Add(line[1]);

                input = Console.ReadLine();
            }

            foreach (var student in mentorsGroup)
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");
                student.Value.Comments
                    .ToList()
                    .ForEach(x => Console.WriteLine($"- {x}"));

                Console.WriteLine("Dates attended:");

                student.Value.Dates
                    .OrderBy(x => x)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"-- {x:dd/MM/yyyy}"));
            }
        }

        private static void AddStudentsToGroup(SortedDictionary<string, Student> mentorsGroup, string input)
        {
            var line = input.Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string name = line[0];
            var dates = line.Skip(1)
                .Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                .ToList();

            if (!mentorsGroup.ContainsKey(name))
            {
                mentorsGroup[name] = new Student();
                mentorsGroup[name].Dates = new List<DateTime>();
                mentorsGroup[name].Comments = new List<string>();
            }
            mentorsGroup[name].Dates.AddRange(dates);
        }
    }
}
