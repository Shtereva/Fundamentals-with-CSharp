using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Exercises
{
    class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }

        public static Exercise Read(string exercise)
        {
            var line = exercise.Split(" ->,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            return new Exercise
            {
                Topic = line[0],
                CourseName = line[1],
                JudgeContestLink = line[2],
                Problems = line.Skip(3).ToList()
            };
        }
    }
    class Exercises
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>();

            while (input != "go go go")
            {
                var exercises = Exercise.Read(input);
                AddExercisesToCollection(dictionary, exercises);

                input = Console.ReadLine();
            }

            PrintResult(dictionary);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>> dictionary)
        {
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Exercises: {kvp.Key}");

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"Problems for exercises and homework for the \"{item.Key}\" course @ SoftUni.");
                    Console.Write("Check your solutions here: ");

                    foreach (var link in item.Value)
                    {
                        Console.WriteLine(link.Key);
                        int count = 1;

                        foreach (var problem in link.Value)
                        {
                            Console.WriteLine($"{count}. {problem}");
                            count++;
                        }
                    }
                }
            }
        }

        private static void AddExercisesToCollection(Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>> dictionary, Exercise exercises)
        {
            if (!dictionary.ContainsKey(exercises.Topic))
            {
                dictionary[exercises.Topic] = new Dictionary<string, Dictionary<string, List<string>>>();
            }

            if (!dictionary[exercises.Topic].ContainsKey(exercises.CourseName))
            {
                dictionary[exercises.Topic][exercises.CourseName] = new Dictionary<string, List<string>>();
            }

            if (!dictionary[exercises.Topic][exercises.CourseName].ContainsKey(exercises.JudgeContestLink))
            {
                dictionary[exercises.Topic][exercises.CourseName][exercises.JudgeContestLink] = new List<string>();
            }

            dictionary[exercises.Topic][exercises.CourseName][exercises.JudgeContestLink].AddRange(exercises.Problems);
        }
    }
}
