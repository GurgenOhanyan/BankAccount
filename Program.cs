using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string [] args)
        {
            BankAccount obj = new BankAccount();
            obj.Balance = 0.0m;
            try
            {
                Console.WriteLine(obj.Balance);
                obj.InterestRate = 10.0m;
                obj.Deposit(150.0m);
                Console.WriteLine(obj.Balance);
                obj.WithDraw(20.0m);
                Console.WriteLine(obj.Balance);
                //NegativeAmountException
                //obj.Deposit(-4.8m);
                //WithDrawException
                //obj.WithDraw(2000.3m);
                //InterestRateExceptions
                //obj.InterestRate = 25.7m;
                //obj.Deposit(40);
            }
            catch (NegativeAmountException n)
            {
                Console.WriteLine(n.Message);
            }
            catch (WithDrawException w)
            {
                Console.WriteLine(w.Message);
            }
            catch(InterestRateExceptions i)
            {
                Console.WriteLine(i.Message);
            }
            
        }
    }
}
