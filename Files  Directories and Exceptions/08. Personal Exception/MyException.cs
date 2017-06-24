using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Personal_Exception
{
    class MyException : Exception
    {
        public MyException() : base("My first exception is awesome!!!")
        {
            
        }
    }
}
