using System;
using System.Linq;

public class SequenceOfCommands
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string[] command = Console.ReadLine().Split(' ').ToArray();

        while (command[0] != "stop")
        {
            int[] args = new int[2];

            if (command[0].Equals("add") ||
                command[0].Equals("subtract") ||
                command[0].Equals("multiply"))
            {
                args[0] = int.Parse(command[1]);
                args[1] = int.Parse(command[2]);

                PerformAction(array, command[0], args);
            }

            else
            {
                PerformAction(array, command[0], args);
            }

            PrintArray(array);
            Console.WriteLine();

            command = Console.ReadLine().Split(' ').ToArray(); ;
        }
    }

    static long[] PerformAction(long[] arr, string action, int[] args)
    {
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                arr[pos - 1] *= value;
                break;
            case "add":
                arr[pos - 1] += value;
                break;
            case "subtract":
                arr[pos - 1] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(arr);
                break;
            case "rshift":
                ArrayShiftRight(arr);
                break;
        }
        return arr;
    }

    private static long[] ArrayShiftRight(long[] arr)
    {
        long[] oldArray = arr.Clone() as long[];
        arr[0] = oldArray[oldArray.Length - 1];
        for (int i = 1; i <= oldArray.Length - 1; i++)
        {
            arr[i] = oldArray[i - 1];
        }
        return arr;
    }

    private static long[] ArrayShiftLeft(long[] arr)
    {
        long[] oldArray = arr.Clone() as long[];
        arr[arr.Length - 1] = oldArray[0];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            arr[i] = oldArray[i + 1];
        }
        return arr;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
