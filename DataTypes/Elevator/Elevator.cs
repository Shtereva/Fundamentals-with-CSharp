using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;
            if ((double)people % capacity != 0)
            {
                courses = (int)Math.Ceiling((double)(people) / capacity);
            }
            else
            {
                courses = people / capacity;
            }
            Console.WriteLine(courses);
        }
    }
}
