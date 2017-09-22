using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class AccountClassBase
    {
        protected double accountNumber;
        protected double savingsAccountBalance;
        protected double checkingAccountBalance;
        protected string accountType;

        public double AccountNumber
        {
            get { return this.accountNumber; }
        }
        public double SavingsAccountBalance
        {
            get { return this.savingsAccountBalance; }
        }
        public double CheckingAccountBalance
        {
            get { return this.checkingAccountBalance; }
        }
        public string AccountType
        {
            get { return this.accountType; }
        }

        public AccountClassBase()
        {

        }
        public AccountClassBase(double accountNumber, double savingsAccountBalance, double checkingAccountBalance, string accountType)
        {
            this.accountNumber = accountNumber;
            this.savingsAccountBalance = savingsAccountBalance;
            this.checkingAccountBalance = checkingAccountBalance;
            this.accountType = accountType;
        }

        //public virtual void 
    }
}
