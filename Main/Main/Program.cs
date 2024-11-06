using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account("Shanjidul Islam","2550", 5000);

            a.ShowBalance(a);
            a.deposit(2000000);
            a.ShowBalance(a);
            a.withdraw(1500);
            a.ShowBalance(a);
            a.withdraw(20000);
            a.ShowBalance(a);

            Account a2 = new Account();

            a.AcName = "Nam nai";
            a.AcID = "2012";
            a.AcBalance = 20000;

            a2.ShowBalance(a2);
            a2.deposit(405000);
            a2.ShowBalance(a2);
            a2.withdraw(7500000);
            a2.ShowBalance(a2);

            a.transfer(4560, a2);
            a.ShowBalance(a);
            a2.ShowBalance(a2);

            a.transfer(80, a2);
            a.ShowBalance(a);
            a2.ShowBalance(a2);

           

            Console.ReadKey();
        }

    }
}
