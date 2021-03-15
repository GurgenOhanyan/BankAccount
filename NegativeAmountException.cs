using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class NegativeAmountException:Exception
    {
        public NegativeAmountException()
        {
            Console.WriteLine("You have a negative account entered:");
        }
    }
}
