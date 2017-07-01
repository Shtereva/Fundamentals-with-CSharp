using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Camera_View
{
    class CameraView
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skip = nums[0];
            int take = nums[1];

            var text = Console.ReadLine();
            var regex = new Regex(@"\|<\w{" + skip + @"}\w{1," + take + "}");

            var matches = regex.Matches(text);
            var result = new List<string>();

            foreach (Match match in matches)
            {
                result.Add(new string(match.Value.Skip(skip + 2).Take(take).ToArray()));
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
