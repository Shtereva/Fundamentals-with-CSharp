using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int operandOne = int.Parse(Console.ReadLine()); 
            char operatorCalculate = char.Parse(Console.ReadLine());
            int operandTwo = int.Parse(Console.ReadLine());
            switch (operatorCalculate)
            {
                case '+': Console.WriteLine($"{operandOne} + {operandTwo} = {operandOne + operandTwo}"); break;
                case '-': Console.WriteLine($"{operandOne} - {operandTwo} = {operandOne - operandTwo}"); break;
                case '*': Console.WriteLine($"{operandOne} * {operandTwo} = {operandOne * operandTwo}"); break;
                case '/': Console.WriteLine($"{operandOne} / {operandTwo} = {operandOne / operandTwo}"); break;
                case '%': Console.WriteLine($"{operandOne} % {operandTwo} = {operandOne % operandTwo}"); break;
            }

        }
    }
}
