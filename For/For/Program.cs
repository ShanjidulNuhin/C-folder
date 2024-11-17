using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter Collumn:");
            double n =Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Row:");
            double m=Convert.ToDouble(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" ");
                }
                for(int k=1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
