using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For Intger
            string a = "23";//if I put a charecter it there will show a run time error
            int b = Convert.ToInt32(a);//to convert the string value in integer=ToInt32 "int is 32 bits"
            Console.WriteLine(b);

            Console.WriteLine();

            //For Long
            string c = "-90000000000";
            long num = Convert.ToInt64(c);//long is 64 bits 
            Console.WriteLine(num);

            Console.WriteLine();

            //For Double
            string d = "50.10";
            double e = Convert.ToDouble(d);
            Console.WriteLine(e);

            Console.WriteLine();

            //For Float
            string f = "9.001";
            float g = Convert.ToSingle(f);//For convert into float have to use 'toSingle'
            Console.WriteLine(g);

            Console.WriteLine();

            //For decimal
            string h = "69.77";
            decimal i= Convert.ToDecimal(h);
            Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
