using System;

namespace BankAccountProject
{
    internal class Savings
    {
        public string Balance { get; internal set; }

        internal void Deposit(double deposit)
        {
            throw new NotImplementedException();
        }

        internal bool Withdrawl(double withdrawl)
        {
            throw new NotImplementedException();
        }

        internal void TransactionFee()
        {
            throw new NotImplementedException();
        }
    }
}