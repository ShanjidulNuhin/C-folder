using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int a = -20;//Initialization
            Console.WriteLine(a);
            Console.WriteLine(int.MaxValue);
           Console.WriteLine(int.MinValue);

            Console.WriteLine( );

            double d = 50.20;//all . are double for C# compiler
            Console.WriteLine(d);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            Console.WriteLine();

            float f = 50.00001f;//as all . are double so 'f' is for telling that the numb is float number
            Console.WriteLine(f);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            Console.WriteLine();

            decimal e = 20.55555M;//'M' is for declearing the number is decimal number
            Console.WriteLine(e);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            a = 50;//simple assign value

            string name = "ali";
            Console.WriteLine("\nYour name is " + name);
            Console.ReadKey();
        }
    }
}
