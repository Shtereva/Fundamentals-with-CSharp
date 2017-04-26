using System;

class InstructionSet
{
    static void Main()
    {
        string instruction = Console.ReadLine().ToLower();

        while (instruction != "end")
        {
            string[] codeArgs = instruction.Split(' ');

            long result = 0;
            switch (codeArgs[0])
            {
                case "inc":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        operandOne++;
                        result = operandOne;
                        break;
                    }
                case "dec":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        operandOne--;
                        result = operandOne;
                        break;
                    }
                case "add":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "mla":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
            }
            Console.WriteLine(result);
            instruction = Console.ReadLine().ToLower();
        }
    }
}