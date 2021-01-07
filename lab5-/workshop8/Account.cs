using System;

namespace Bank
{
    class Account
    {
        private long _accountNumber;

        private string _cusomerName;

        protected double Balance = 500;

        protected virtual void SetDetails(string name, long number)
        {
            this._cusomerName = name;
            this._accountNumber = number;
        }

        protected virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }

        protected virtual void Deposit(double amount)
        {
            Balance += amount;
        }

        public virtual void Display()
        {
            Console.WriteLine("\n\nA/C No. \tCustomer Name \t Balance{$} ");
            Console.WriteLine(_accountNumber + "\t\t" + _cusomerName + " \t " + Balance);

        }

        protected abstract double BankCharges();
    }
}
