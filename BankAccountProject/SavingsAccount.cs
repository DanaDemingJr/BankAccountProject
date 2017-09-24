using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class SavingsAccount : AccountClassBase
    {
        private string savingsAccountNumber;
        private double savingsAccountBalance;
        private double minimumSavingsBalance = 25;

        public string SavingsAccountNumber
        {
            get { return this.savingsAccountNumber; }
        }

        public double SavingsAccountBalance
        {
            get { return this.savingsAccountBalance; }
            set { this.savingsAccountBalance = value; }
        }

        public double MinimumSavingsBalance
        {
            get { return this.minimumSavingsBalance; }
        }
    
        public SavingsAccount()
        {
            this.savingsAccountNumber = "9374729283";
            this.savingsAccountBalance = 10522;
        }

        public void CheckBalance()
        {
           Console.WriteLine("For savings account number {0} the balance is ${1}", savingsAccountNumber, savingsAccountBalance);
        }
        public override void AccountDeposit() 
        {
            Console.WriteLine();
            Console.WriteLine("Starting savings account balance is: " + "$" + savingsAccountBalance);
            Console.WriteLine("How much would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            savingsAccountBalance += deposit;
            Console.WriteLine();
            Console.WriteLine("Your new savings account balance is: " + "$" + savingsAccountBalance);
            Console.WriteLine();
        }

        public override void AccountWithdrawal()
        {
            Console.WriteLine();
            Console.WriteLine("Your starting savings account balance is: " + "$" + savingsAccountBalance);
            Console.WriteLine("How much would you like to withdraw?");
            double withdrawal = Double.Parse(Console.ReadLine());
            savingsAccountBalance -= withdrawal;

            if (savingsAccountBalance >= 25)
            {
                Console.WriteLine("Your new savings balance is: " + "$" + savingsAccountBalance);
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("You must keep at least : " + "$" + minimumSavingsBalance + " in your account");
                savingsAccountBalance += withdrawal;
                Console.WriteLine("Remember your savings account balance is: " + "$" + savingsAccountBalance);
                Console.WriteLine();
            }

        }

        }
}
