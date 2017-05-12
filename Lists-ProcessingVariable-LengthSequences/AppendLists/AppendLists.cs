using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLists
{
    class AppendLists
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split('|').ToList();
            nums.Reverse();
            var result = new List<string>();   
            foreach (var item in nums)
            {
                var splited = item.Split(new char[] { ' '} , StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(splited);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
