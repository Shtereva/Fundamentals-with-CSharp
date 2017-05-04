using System;
using System.Linq;


namespace ResizableArray
{
    class ResizableArray
    {
        static void Main()
        {
            int lenght = 4;
            Nullable<int>[] array = new Nullable<int>[lenght];

            var command = Console.ReadLine().Split(' ');
            int elements = 0;

           while (!command[0].Equals("end"))
            {
                if (elements == lenght)
                {
                    lenght *= 2;
                    Nullable<int>[] biggerArray = new Nullable<int>[lenght];
                    for (int i = 0; i < array.Length; i++)
                    {
                        biggerArray[i] = array[i];
                    }
                    array = biggerArray.Clone() as int?[];
                }
                switch (command[0])
                {
                    case "push":
                        elements = CommandPush(array, command, elements); 
                        break;
                    case "pop":
                        elements = CommandPop(array, elements); 
                        break;
                    case "clear":
                        elements = CommandClear(array, elements); 
                        break;
                    case "removeAt":
                        elements = CommandRemoveAt(array, command, elements); 
                        break;
                }

                command = Console.ReadLine().Split(' ');
            }
            Console.WriteLine(elements <= 0 ? "empty array" : string.Join(" ", array));
        }

        private static int CommandRemoveAt(int?[] array, string[] command, int elements)
        {
            array.SetValue(null, int.Parse(command[1]));
            for (int i = int.Parse(command[1]); i < array.Length; i++)
            {
                if (i == array.Length - 1) { break; }
                array.SetValue(array[i + 1], i);
                array.SetValue(null, i + 1);
            }
            elements--;
            return elements;
        }

        private static int CommandClear(int?[] array, int elements)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array.SetValue(null, i);
            }
            elements = 0;
            return elements;
        }

        private static int CommandPop(int?[] array, int elements)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i].HasValue)
                {
                    array.SetValue(null, i);
                    elements--;
                    break;
                }
            }
            return elements;
        }

        private static int CommandPush(int?[] array, string[] command, int elements)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (!array[i].HasValue)
                {
                    array.SetValue(int.Parse(command[1]), i);
                    elements++;
                    break;
                }
            }
            return elements;
        }
    }
}
