using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class SavingsAccount : AccountClassBase
    {
        private double minimumBalance;
        
        public double MinimumBalance
        {
            get { return this.minimumBalance; }
        }
        


        public SavingsAccount(double accountNumber, double savingsAccountBalance, double checkingAccountBalance, string accountType, double minimumBalance)
        {
            this.accountNumber = accountNumber;
            this.savingsAccountBalance = savingsAccountBalance;
            this.checkingAccountBalance = checkingAccountBalance;
            this.accountType = accountType;
            this.minimumBalance = minimumBalance;
        }

        public SavingsAccount()
        {
            this.accountNumber = 923104567;
            this.savingsAccountBalance = 150.0d;
        }
    }
}
