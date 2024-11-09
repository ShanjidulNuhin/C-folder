using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_IF_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your Name: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Hi {name}\n");
                Console.WriteLine("Enter your age: ");
                double age =Convert.ToDouble(Console.ReadLine());
                if(age >=18 && age <= 110)
                {
                    Console.WriteLine($"{name} You are {age}, and you can apply... ...");
                }else if(age >= 110)
                {
                    Console.WriteLine("Invalid age");
                    Console.WriteLine("Enter Currect age\n");
                    continue;
                }
                else
                {
                    Console.WriteLine($"{name} your age is {age}. You are under 18 so you can not apply\n");
                }
                Console.WriteLine("Do you like to apply again?");
                string ans= Console.ReadLine();
                if (ans.ToLower() != "yes")
                {
                    Console.WriteLine("Have a nice day... ...");
                    break;
                }

            }

            Console.ReadKey();
        }
    }
}
