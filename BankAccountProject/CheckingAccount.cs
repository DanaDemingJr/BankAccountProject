using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class CheckingAccount : AccountClassBase
    {
        private string accountNumber;
        private double accountBalance;

        public string AccountNumber
        {
            get { return this.accountNumber; }
            
        }

        public double AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        public CheckingAccount()
        {
            this.accountNumber = "938422984";
            this.accountBalance = 4387;
        }

        public void CheckBalance()
        {
            Console.WriteLine(" For Checking Account number {0}, the balance is ${1}", accountNumber, accountBalance);
        }

        public override void AccountWithdrawal()
        {
            Console.WriteLine();
            Console.WriteLine("Current Checking Account balance is: " + "$" + accountBalance);
            Console.WriteLine("How much would you like to withdraw?");
            double withdrawal = Double.Parse(Console.ReadLine());
            accountBalance -= withdrawal;

            if (accountBalance > withdrawal)
            {
                Console.WriteLine("Your new balance is: " + "$" + accountBalance);
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("This will cause an overdraft, please withdraw a smaller amount");
                accountBalance += withdrawal;
                Console.WriteLine("Please remember your account balance is " + "$" + accountBalance);
                Console.WriteLine();
            }
        }

            public override void AccountDeposit()
        {
            Console.WriteLine();
            Console.WriteLine("Current Checking Account balance is: " + "$" + accountBalance);
            Console.WriteLine("How much would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            accountBalance += deposit;
            Console.WriteLine("Your new balance is: " + "$" + accountBalance);
            Console.WriteLine();
        }
    }

 
}
