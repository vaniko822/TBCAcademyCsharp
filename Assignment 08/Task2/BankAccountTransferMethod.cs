using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    partial class BankAccount
    {
        public void TransferFunds(BankAccount target, decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Sheni tanxa minusebshia!");
            }

            if (amount > _balance.Amount)
            {
                Console.WriteLine("Ar gaqvt sakmarisi tanxa!");
            }

            Withdraw(amount);
            target.Deposit(amount);
            Console.WriteLine($"Transferi warmatebit shesrulda - {_accountHolderName}-ma gadauricxa {target._accountHolderName}");
        }
    }
}
