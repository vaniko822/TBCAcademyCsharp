using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public partial class BankAccount
    {
        private string _accountNumber { get; set; }
        private string _accountHolderName { get; set; }
        private Currency _balance;

        public BankAccount(string accountNumber, string accountHolderName, decimal amount, string currency)
        {
            _accountNumber = accountNumber;
            _accountHolderName = accountHolderName;
            _balance = new Currency(amount, currency);
        }


        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Sheni tanxa minusebshia!");
            }

            if (amount > _balance.Amount)
            {
                Console.WriteLine("Ar gaqvt sakmarisi tanxa!");
            }

            _balance.Amount -= amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Depositis tanxa unda iyos 0ze meti!");
            }

            _balance.Amount += amount;
        }

        public void BalanceCheck()
        {
            Console.WriteLine($"{_accountHolderName}, Balansze arsebuli tanxa sheadgens - {_balance.Amount} {_balance.CurrencyC}");
        }
    }

    public struct Currency
    {
        private decimal _amount;
        private string _currency;

        public decimal Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }

        public string CurrencyC
        {
            get
            {
                return _currency;
            }
            set
            {
                _currency = value;
            }
        }

        public Currency(decimal amount, string currency)
        {
            this._amount = amount;
            this._currency = currency;
        }
    }
}
