using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class InterestRateExceptions:Exception
    {
        public InterestRateExceptions()
        {
            Console.WriteLine("It is not possible to make a deposit at the mentioned interest rate։");
        }
        
    }
}
