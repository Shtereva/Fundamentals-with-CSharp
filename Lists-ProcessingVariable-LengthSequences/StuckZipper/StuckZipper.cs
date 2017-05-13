using System;
using System.Collections.Generic;
using System.Linq;

namespace StuckZipper
{
    class StuckZipper
    {
        static void Main()
        {
            var listOne = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var listTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count1 = int.MaxValue;
            int count2 = int.MaxValue;
            CountElementsLenght(listOne, listTwo, ref count1, ref count2);
            int smallestElement = Math.Min(count1, count2);
            RemovingLargerElements(listOne, listTwo, smallestElement);
            MergingLists(listOne, listTwo);
            Console.WriteLine(string.Join(" ", listTwo));
        }

        private static void MergingLists(List<int> listOne, List<int> listTwo)
        {
            int index = 1;
            for (int i = 0; i < listOne.Count; i++)
            {
                listTwo.Insert(index, listOne[i]);
                index += 2;
                if (index > listTwo.Count) { index--; }
            }
        }

        private static void RemovingLargerElements(List<int> listOne, List<int> listTwo, int smallestElement)
        {
            for (int i = 0; i < listOne.Count; i++)
            {
                int element = Math.Abs(listOne[i]);
                if (element.ToString().Length > smallestElement)
                {
                    listOne.Remove(listOne[i]);
                    i--;
                }
            }

            for (int i = 0; i < listTwo.Count; i++)
            {
                int element = Math.Abs(listTwo[i]);
                if (element.ToString().Length > smallestElement)
                {
                    listTwo.Remove(listTwo[i]);
                    i--;
                }
            }
        }

        private static void CountElementsLenght(List<int> listOne, List<int> listTwo, ref int count1, ref int count2)
        {
            for (int i = 0; i < listOne.Count; i++)
            {
                int element = Math.Abs(listOne[i]);
                if (element.ToString().Length < count1)
                {
                    count1 = element.ToString().Length;
                }
            }

            for (int i = 0; i < listTwo.Count; i++)
            {
                int element = Math.Abs(listTwo[i]);
                if (listTwo[i].ToString().Length < count2)
                {
                    count2 = element.ToString().Length;
                }
            }
        }
    }
}
