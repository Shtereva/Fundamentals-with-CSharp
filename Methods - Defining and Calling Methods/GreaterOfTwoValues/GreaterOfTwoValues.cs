using System;


namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            string type = Console.ReadLine();
            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();
            string result = GetMax(inputOne, inputTwo, type);
            Console.WriteLine(result);
            
        }

         static string GetMax(string inputOne, string inputTwo, string type)
        {
            string result = string.Empty;
            switch (type)
            {
                case "int":
                    int greaterNum = Math.Max(int.Parse(inputOne), int.Parse(inputTwo));
                    result = Convert.ToString(greaterNum);
                    break;
                case "char":
                    char one = Convert.ToChar(inputOne);
                    char two = Convert.ToChar(inputTwo);
                    if (one > two) { result = one.ToString(); }
                    else { result = two.ToString(); }
                    break;
                case "string":
                    if (inputOne.CompareTo(inputTwo) >= 0)
                    {
                        result = inputOne;
                    }
                    else
                    {
                        result = inputTwo;
                    }
                    //if (inputOne.Length > inputTwo.Length) { result = inputOne; }
                    //else { result = inputTwo; }
                    break;
            }
            return result; 
        }
    }
}
