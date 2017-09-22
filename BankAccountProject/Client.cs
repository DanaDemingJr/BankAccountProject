using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Client
    {
        protected string clientName;
        protected float clientPhoneNumber;
        protected string clientAddress;
        protected string clientRepresentative;

        public string ClientName
        {
            get { return this.clientName; }
        }

        public Client(string clientName, float clientPhoneNumber, string clientAddress, string clientRepresentative)
        {
            this.clientName = clientName;
            this.clientPhoneNumber = clientPhoneNumber;
            this.clientAddress = clientAddress;
            this.clientRepresentative = clientRepresentative;
        }

        public Client()
        {
            this.clientName = "DD Collectibles";
            this.clientPhoneNumber = 440 - 773 - 6566;
            this.clientAddress = "3202 Tuxedo Ave Parma, OH 44134";
            this.clientRepresentative = "Dana Deming Jr";
        }

        public void ClientWork()
        {
            Console.WriteLine("This is the client detail information for DD Collectibles");
            Console.WriteLine("Phone number 440-773-6566 ");
            Console.WriteLine("Client address: 3202 Tuxedo Ave. Parma, OH 44134");
            Console.WriteLine("Client Representative Name: Dana Deming Jr");
            Console.WriteLine();
        }


    }
    }
