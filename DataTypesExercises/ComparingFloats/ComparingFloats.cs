using System;


namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool comparison = true;
            if (Math.Abs(a - b) >= eps)
            {
                comparison = false;
            }
            else 
            {
                comparison = true;
            }
            Console.WriteLine(comparison);
        }
    }
}
