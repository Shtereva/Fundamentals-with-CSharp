using System;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main()
        {
            var array = Console.ReadLine().Split();
            string output = string.Empty;
            int counter = 1;
            int maxCounter = 0;
            CheckEquals(array, ref output, ref counter, ref maxCounter);

            Console.WriteLine(output);
        }

        private static void CheckEquals(string[] array, ref string output, ref int counter, ref int maxCounter)
        {
            int decreased = 2;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                for (int j = array.Length - decreased; j >= 0; j--)
                {
                    if (array[i].Equals(array[j]))
                    {
                        counter++;
                    }

                }

                if (counter >= maxCounter)
                {
                    output = array[i];
                    maxCounter = counter;
                }

                decreased++;
                counter = 1;
            }
        }
    }
}
