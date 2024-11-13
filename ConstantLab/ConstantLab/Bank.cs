using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantLab
{
    internal class Bank
    {
        const int DailyTransactionLimt = 5000;//entity constant
        readonly int CreditLimit=40000;//run time constant(Value declear optional)

        public Bank(int c1)
        {
            this.CreditLimit = c1;
        }
        static void Main(string[] args)
        {
            Bank b1=new Bank(10000);
            Bank b2 = new Bank(2000);
            Bank b3 = new Bank(3000);

            Console.WriteLine("Daily Transaction Limt: "+ Bank.DailyTransactionLimt);
            Console.WriteLine(b1.CreditLimit);
            Console.WriteLine(b2.CreditLimit);
            Console.WriteLine(b3.CreditLimit);

            Console.ReadKey();
        }
    }
}
