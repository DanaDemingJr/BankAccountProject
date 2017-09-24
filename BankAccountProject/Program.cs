using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        private static string clientAddress;
        private static string clientName;
        private static float clientPhoneNumber;
        private static string clientRepresentative;
        private static int num;
        static void Main(string[] args)
        {   
            //instantiate below 
            Client client2 = new Client(clientName, clientPhoneNumber, clientAddress, clientRepresentative);
            CheckingAccount checking1 = new CheckingAccount();
            SavingsAccount savings1 = new SavingsAccount();

            do
            {
                Console.WriteLine("Select the number of your choice: ");
                Console.WriteLine("1: View Client Information");
                Console.WriteLine("2: View Account Balances");
                Console.WriteLine("3: Deposit Funds");
                Console.WriteLine("4: Withdraw Funds");
                Console.WriteLine("5: Quit");
                var userChoice = Console.ReadLine();
                Console.WriteLine();
                if (!Int32.TryParse(userChoice, out num)) continue;

                if (userChoice == "5")
                {
                    Environment.Exit(0);
                }

                Console.WriteLine("Choice = " + userChoice);

                if (userChoice == "1")
                {
                    client2.ClientWork();
                    Console.WriteLine();
                }
                else if (userChoice == "2")

                {
                    Console.WriteLine("1 - Checking Balance");
                    Console.WriteLine("2 - Savings Balance");
                    int accountSelection = int.Parse(Console.ReadLine());
                    if (accountSelection == 1)
                    {
                        checking1.CheckBalance();
                        Console.WriteLine();
                    }
                    else if (accountSelection == 2)
                    {
                        savings1.CheckBalance();
                        Console.WriteLine();
                    }

                }
                else if (userChoice == "3")
                {
                    Console.WriteLine("1 - Checking Deposit");
                    Console.WriteLine("2 - Savings Deposit");
                    int withdrawalSelection = int.Parse(Console.ReadLine());
                    if (withdrawalSelection == 1)
                    {
                        checking1.AccountDeposit();
                        Console.WriteLine();
                    }
                    else if (withdrawalSelection == 2)
                    {
                        savings1.AccountDeposit();
                        Console.WriteLine();
                    }
                }
                else if (userChoice == "4")
                {
                    Console.WriteLine("1 - Checking Withdrawal");
                    Console.WriteLine("2 - Savings Withdrawal");
                    int withdrawalSelection = int.Parse(Console.ReadLine());
                    if (withdrawalSelection == 1)
                    {
                        checking1.AccountWithdrawal();
                        Console.WriteLine();
                    }
                    else if (withdrawalSelection == 2)
                    {
                        savings1.AccountWithdrawal();
                        Console.WriteLine();
                    }
                }


            } while (true);
        }

        
    }
}
