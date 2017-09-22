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
        private static string userSecondChoice;

        static void Main(string[] args)
        {
             Client client2 = new Client(clientName, clientPhoneNumber, clientAddress, clientRepresentative);
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
                }
                else if (userChoice == "2")

                {
                    Console.WriteLine("A - Checking Balance");
                    Console.WriteLine("B - Savings Balance");
                    if (userSecondChoice == "1")
                    {
                        Console.WriteLine("100");
                    }
                    else if (userSecondChoice == "2")
                    {
                        Console.WriteLine("150");
                    }
                }
                //else if (userChoice == "3")
                //{
                //    storm2.SleepyTime();
                //}
                //else if (userChoice == "4")
                //{
                //    storm2.BathRoomBreak();
                //}


            } while (true);
        }
    }
}
