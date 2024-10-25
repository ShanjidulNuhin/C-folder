using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello world");
              Console.Write("Enter Your Name: ");
              string name=Console.ReadLine();
              Console.WriteLine("Enter your age:");
              int age=Convert.ToInt32(Console.ReadLine());
              Console.Write("Hello "+name);
              Console.WriteLine("Youur age is "+age);*/

              int num1, num2;
              Console.Write("Enter any number: ");
              num1 = Convert.ToInt32(Console.ReadLine());
              Console.Write("Enter another number: ");
              num2 = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("Sum= "+(num1+ num2));
              Console.WriteLine("sub= "+(num1-num2));
              Console.WriteLine("mul= "+(num1*num2));
              Console.WriteLine("sub= "+(num1/num2));

            Console.Write("Enter any word: ");
            string n =Console.ReadLine();

            Console.Write("Enter again: ");
            string o = Console.ReadLine();

            Console.WriteLine($"The worde are: {n},{o}");

           
            Console.ReadKey();
        }
    }
}
