using System;


namespace Notification
{
    class Notification
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string result = Console.ReadLine();
                    if (result == "success")
                        {
                            string operation = Console.ReadLine();
                            string message = Console.ReadLine();
                            string output = ShowSuccess(operation, message);
                            Console.WriteLine(output);
                        }

                   else if (result == "error")
                        {
                            string operation = Console.ReadLine();
                            int code = int.Parse(Console.ReadLine());
                            string output = ShowError(operation, code);
                            Console.WriteLine(output);
                        }
                    else
                        {
                            continue;
                        }
            }
        }

        static string ShowSuccess(string operation, string message)
        {
            string output = string.Format(@"Successfully executed {0}.
==============================
Message: {1}.", operation, message);
            return output;
        }

        static string ShowError(string operation, int code)
        {
            string possitive = string.Format(code > 0 ? "Reason: Invalid Client Data." : "Reason: Internal System Failure.");
            string output = string.Format(@"Error: Failed to execute {0}.
==============================
Error Code: {1}.
{2}", operation, code, possitive);
             return output;
        }
    }
}
