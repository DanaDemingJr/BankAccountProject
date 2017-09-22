using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class CheckingAccount : AccountClassBase
    {
        public CheckingAccount(double accountNumber, double checkingAccountBalance, string accountType)
        {
            this.accountNumber = accountNumber;
            this.checkingAccountBalance = checkingAccountBalance;
            this.accountType = accountType;
        }
    }
}
