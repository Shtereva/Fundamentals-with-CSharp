using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Stateless
{
    class Stateless
    {
        static void Main()
        {
            string state = Console.ReadLine();
            string fiction = Console.ReadLine();

            while (state != "collapse")
            {
                while (fiction.Length > 0)
                {
                    state = state.Replace(fiction, "");
                    fiction = fiction.Remove(0, 1);

                    if (fiction.Length > 0)
                    {
                        fiction = fiction.Remove(fiction.Length - 1, 1);
                    }
                }

                Console.WriteLine(state.Length > 0 ? state.Trim() : "(void)");
                state = Console.ReadLine();
                fiction = Console.ReadLine();
            }
        }
    }
}
