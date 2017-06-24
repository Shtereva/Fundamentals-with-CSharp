using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Personal_Exception
{
    class PersonalException
    {
        static void Main()
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                try
                {
                    if (num < 0)
                    {
                        throw new MyException();
                    }

                    Console.WriteLine(num);
                }
                catch (MyException e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
                
            }
        }
    }
}
