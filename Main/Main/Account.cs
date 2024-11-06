using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Account
    {
        private string _acName;
        private string _acID;
        private double _acBalance;

        internal Account() { }
        internal Account(string acName, string acID, double acBalance)
        {
            _acName = acName;
            _acID = acID;
            _acBalance = acBalance;
        }
        public string AcName
        {
            set { _acName = value; }
            
        }
        public string AcID
        {
            set { _acID = value; }
            
        }
        public double AcBalance
        {
            set { _acBalance = value; }
        }
        internal void deposit(double amount)
        {
            if (_acBalance < 0)
            {
                Console.WriteLine(amount+ " Cannot possible \n");
            }
            else
            {
                _acBalance += amount;
                Console.WriteLine(amount+" has been deposit \n");
            }

        }
        internal void withdraw(double amount)
        {
            if (_acBalance < amount)
            {
                Console.WriteLine("You can not Withdraw "+amount);
                Console.WriteLine();
            }
            else
            {
                _acBalance -= amount;
                Console.WriteLine("You can withdraw " + amount);
                Console.WriteLine();
            }
        }
        internal void transfer(double amount, Account receiver)
        {
            if (_acBalance < amount)
            {
                Console.WriteLine("You cannot transfer\n");
            }
            else
            {
                _acBalance -= amount;
                receiver._acBalance += amount;

                Console.WriteLine("You can transfer " +amount);
                Console.WriteLine();
            }
        }
        public void ShowBalance(Account a)
        {
            Console.WriteLine(_acBalance+" is Your current balance\n");
        }

    }

}
