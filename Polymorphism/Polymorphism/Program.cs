using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class program 
    {
        class newPlay
        {
            public void Play()
            {
                Console.WriteLine("This is an empty element");
            }
            public void Play(int i)
            { Console.WriteLine("This is an integer, the value is "+i); }
            public void Play(double d)
            {
                Console.WriteLine(d + " is a double number");
            }
            public void Play(float f)
            {
                Console.WriteLine(f+ " is a float number");
            }
        }
        public static void Main(string[] args)
        {
            newPlay play = new newPlay();
            /*play.Play();
            play.Play(4);
            play.Play(5.8);
            play.Play(5.3);*/

            Console.WriteLine("Do you like to check the number? (yes/no)");
            string function=Console.ReadLine();
            if (function.ToLower() == "yes")
            {
                Console.WriteLine("Enter any number : ");
                if (int.TryParse(Console.ReadLine(), out int i))
                {
                    Console.WriteLine("This is an integer value");
                }
                else if (double.TryParse(Console.ReadLine(), out double d))
                {
                    Console.WriteLine("This is a double value");
                }
                else
                {
                    Console.WriteLine("Invaled");
                }  
            }
            Console.WriteLine("Do you like to enter again?(yes/no)");
            string fun = Console.ReadLine();
            if (fun.ToLower() == "yes") { Main(args); }
        }
    }   
}
