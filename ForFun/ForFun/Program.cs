using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ForFun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name1 = "Aditto";
            var age = 30;
            var loc = "Dhaka";
            var sal = 30.80;

            var name2 = "Adi";
            var age2 = 20;
            var loc2 = "Dhaka";
            var sal2 = "null";

            var name3 = "Adit";
            var age3 = 40;
            var loc3 = "Dhaka";
            var sal3 = 1000D;

            Console.Write("Write your name between Aditto,,,Adi and Adit: ");
            var name = Console.ReadLine();

            if (name == name1)
            {
                Console.WriteLine("Hi " + name1 + "\nYour age is " + age + "\nYou live in " + loc + "\nYour monthly incom is $" + sal);
            }
            else if (name == name2)
            {
                Console.WriteLine("Hi " + name2 + "\nYour age is " + age2 + "\nYou live in " + loc2 + "\nYou have no income");

            }
            else if (name == name3)
            {
                Console.WriteLine("Hi " + name3 + "\nYour age is " + age3 + "\nYou live in " + loc3 + "\nYour monthly incom is $" + sal3);

            }
            else
            {
                Console.WriteLine("There is no " + name + " here");
            }
            Console.ReadKey();
        }
    }
}
