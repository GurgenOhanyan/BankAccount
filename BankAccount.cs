using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class BankAccount
    {
        public decimal Balance {get;set;}
        public decimal InterestRate { get; set; }
        public void Deposit(decimal amount)  
        {
            if (amount < 0)
            {
                throw new NegativeAmountException();
            }
            if (InterestRate < 0 || InterestRate > 22)
            {
                throw new InterestRateExceptions();
            }
            this.Balance += (1 + this.InterestRate / 100)* amount;
        }
        public void WithDraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new WithDrawException();
            }
            if (amount < 0)
            {
                throw new NegativeAmountException();
            }
            Balance -= amount;
        }
    }
}
