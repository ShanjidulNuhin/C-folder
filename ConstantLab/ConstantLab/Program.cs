using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantLab
{
    internal class Program
    {
        const int num = 100;//class mem.
        int num2;//instance mem.
        static int num3;//class mem.
        static void Main(string[] args)
        {
            Program p = new Program();
            p.num2 = 10;//instance ref

            Program.num3 = 50;//class ref
            Console.WriteLine(Program.num);
            Console.WriteLine(Program.num3);
            Program.num3 = 10;//static value change through the class
            Console.WriteLine(Program.num3);
            
            Console.ReadKey();
        }
    }
}
