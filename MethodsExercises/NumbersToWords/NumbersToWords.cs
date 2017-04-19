using System;


namespace NumbersToWords
{
    class NumbersToWords
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > 999) { Console.WriteLine("too large"); }
                else if (number < -999) { Console.WriteLine("too small"); }
                else if (number.ToString().Length < 3) { }
                else if (number < 0 && number.ToString().Length < 4) { }
                else { Letterize(number.ToString()); }
            }
        }

        private static void Letterize(string number)
        {
            if (number[number.Length - 1] == '0' && number[number.Length - 2] == '0')
            {
                string hundredDigit = RightOnHundreds(number);
                Console.WriteLine(int.Parse(number) > 0 ? "{0}-hundred" : "minus {0}-hundred", hundredDigit);
            }
            if (number[number.Length - 2] == '0' && number[number.Length - 1] != '0')
            {
                string hundredDigit = RightOnHundreds(number);
                string onesDigit = OnesDigits(number);
                Console.WriteLine(int.Parse(number) > 0 ? "{0}-hundred and {1}" : "minus {0}-hundred and {1}", hundredDigit, onesDigit);
            }
            if (number[number.Length - 2] == '1')
            {
                string hundredDigit = RightOnHundreds(number);
                string tenthDigit = TenthDigits(number);
                Console.WriteLine(int.Parse(number) > 0 ? "{0}-hundred and {1}" : "minus {0}-hundred and {1}", hundredDigit, tenthDigit);
            }
            if (number[number.Length - 2] != '0' && number[number.Length - 2] != '1')
            {
                string hundredDigit = RightOnHundreds(number);
                string biggerThanTwenty = BiggerThanTwenty(number);
                string onesDigit = OnesDigits(number);
                Console.WriteLine(int.Parse(number) > 0 ? "{0}-hundred and {1} {2}" : "minus {0}-hundred and {1} {2}", hundredDigit, biggerThanTwenty, onesDigit);
            }
        }

        private static string BiggerThanTwenty(string number)
        {
            string digit = string.Empty;
            switch (number[number.Length - 2])
            {
                case '2': digit = "twenty"; break;
                case '3': digit = "thirty"; break;
                case '4': digit = "forty"; break;
                case '5': digit = "fifty"; break;
                case '6': digit = "sixty"; break;
                case '7': digit = "seventy"; break;
                case '8': digit = "eighty"; break;
                case '9': digit = "ninety"; break;
            }
            return digit;
        }

        private static string TenthDigits(string number)
        {
            string digit = string.Empty;
            switch (number[number.Length - 1])
            {
                case '1': digit = "eleven"; break;
                case '2': digit = "twelve"; break;
                case '3': digit = "thirteen"; break;
                case '4': digit = "fourteen"; break;
                case '5': digit = "fifteen"; break;
                case '6': digit = "sixteen"; break;
                case '7': digit = "seventeen"; break;
                case '8': digit = "eighteen"; break;
                case '9': digit = "nineteen"; break;
            }
            return digit;
        }

        private static string OnesDigits(string number)
        {
            string digit = string.Empty;
            switch (number[number.Length - 1])
            {
                case '1': digit = "one"; break;
                case '2': digit = "two"; break;
                case '3': digit = "three"; break;
                case '4': digit = "four"; break;
                case '5': digit = "five"; break;
                case '6': digit = "six"; break;
                case '7': digit = "seven"; break;
                case '8': digit = "eight"; break;
                case '9': digit = "nine"; break;
            }
            return digit;
        }

        static string RightOnHundreds(string number)
        {
            string digit = string.Empty;
            switch (number[number.Length - 3])
            {
                case '1': digit = "one"; break;
                case '2': digit = "two"; break;
                case '3': digit = "three"; break;
                case '4': digit = "four"; break;
                case '5': digit = "five"; break;
                case '6': digit = "six"; break;
                case '7': digit = "seven"; break;
                case '8': digit = "eight"; break;
                case '9': digit = "nine"; break;
            }
            return digit;
        }
    }
}
