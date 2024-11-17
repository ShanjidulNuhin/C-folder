using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 1 to 7");
            double day=Convert.ToDouble(Console.ReadLine());

            switch (day) 
            {    
                case 1: Console.WriteLine("Sater Day");
                    break;
                case 2: Console.WriteLine("Sunday");
                    break;
                case 3: Console.WriteLine("Monday");
                    break;
                case 4: Console.WriteLine("Tuesday");
                    break;
                case 5: Console.WriteLine("Wednesday");
                    break;
                case 6: Console.WriteLine("Thursday");
                    break;
                case 7: Console.WriteLine("Friday");
                    break;
                    default: Console.WriteLine("Invalid number");
                    break;
            } 
            Console.ReadKey();
        }
    }
}
