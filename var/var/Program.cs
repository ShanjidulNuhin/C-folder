using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*by using var keyword,,the compiler figerout the type of a
            variable by the value */

            //Integer
            var numb = 10;
            Console.WriteLine(numb);

            //Long
            var num = 90000000000000L;//By 'L' it declear the 'num' datatype is 'long'
            Console.WriteLine(num);

            //Double
            var num2 = 13.50;
            Console.WriteLine(num2);

            //Float
            var num3 = 12.82f;//'f' is declear for float number
            Console.WriteLine(num3);

            //Boolian
            var boo = true;
            Console.WriteLine(boo);

            //Random Code
            Console.WriteLine("\t\t\t... ... ...Random code... ... ...");

            double  num1, num4;
            
            Console.WriteLine("Enter two number ");
            Console.Write("/nFirst number: ");
            num1=Convert.ToDouble(Console.ReadLine());
            Console.Write("/nSecond number: ");
            num4=Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num4;
            if (sum > 100)
            {
                Console.WriteLine("The sum of the numbers is " + sum + " and it is bigger then 100");
            }
            else if (sum < 100)
            {
                Console.WriteLine("The sum of the numbers is " + sum + " and it is smaller then 100");
            }
            else
            {
                Console.WriteLine("The sum of the numers is equal to 100");
            }



            Console.ReadKey();
        }
    }
}
