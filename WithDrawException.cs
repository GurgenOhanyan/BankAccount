using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class WithDrawException:Exception
    {
        public WithDrawException()
        {
            Console.WriteLine("You do not have that much money in your account");
        }
    }
}
