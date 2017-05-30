using System;
using System.Collections.Generic;
using System.Linq;



class AverageStudentGrades
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var studentRecord = new Dictionary<string, List<double>>();

        for (int i = 0; i < n; i++)
        {
            var students = Console.ReadLine().Split();
            string name = students[0];
            double grade = double.Parse(students[1]);


            if (!studentRecord.ContainsKey(name))
            {
                studentRecord.Add(name, new List<double>());
            }

            studentRecord[name].Add(grade);
        }

        foreach (var name in studentRecord)
        {
            Console.WriteLine($"{name.Key} -> {string.Join(" ", name.Value.Select(x => string.Format("{0:f2}", x)))} (avg: {name.Value.Average():f2})");
        }
    }
}

