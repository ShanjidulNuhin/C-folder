using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ValidCheck
{
    internal class Program
    {
        static void Main(string[] args)

        {
           Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            string result = age <0 ? "Your age is Valid" : "Inalid age";
            Console.WriteLine(result);

            Console.ReadKey();
            
            Console.Write("Enter year : ");
            double year = Convert.ToDouble(Console.ReadLine());

            string relt = year % 100 != 0 && year % 4 == 0 || year % 400 == 0 ? "This year is leap year" : "this year is not leap year";
            Console.WriteLine(relt);

            Console.Write("Enter two number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1+ num2;
            double mul = num1 * num2;
            double dev = num1 / num2;
            double sub = num1 - num2;

            Console.WriteLine("sum : "+sum);
            Console.WriteLine("mul : "+ mul);
            Console.WriteLine(string.Format("dev : {0:0.00}",dev));
            Console.WriteLine("sub : "+sub);

            Console.Write("Enter a number : ");
            double num = Convert.ToDouble(Console.ReadLine());

            string rslt = num % 2 == 0  ? "This number is an even number... ..." :
                "This number is an odd number... ...";
            Console.Write(rslt);

            //factorial
            Console.Write("Enter a number : ");
            double num0=Convert.ToDouble(Console.ReadLine());
            double factorial = 1;

            for (int i = 0; i <= num0; i++) { 
            factorial *= i;
            }
            Console.WriteLine("The factorial is : " +factorial);

            //Fibonacci
            Console.Write("Enter the number: ");
            int terms = int.Parse(Console.ReadLine());

            int first = 0, second = 1, next;

            Console.Write("Fibonacci sequence: ");
            for (int i = 0; i < terms; i++)
            {
                Console.Write(first + " ");
                next = first + second;
                second = next;
                first = second;
            }
            
            //reversed arry
            Console.Write("Enter a string : ");
            string inp = Console.ReadLine();
            Console.WriteLine("Your input is : "+inp);
            char[] charArr = inp.ToCharArray();//convert the string into array
            Array.Reverse(charArr);//to everse the string
            string reverse = new string(charArr);//create new string for reverse
            Console.WriteLine("The Reversed string is : "+reverse);

            //find largest number
            double[] num4 = new double[] { 1, 2, 3, 4, 5, 5, 8, 7, 8, 2, 9, 2, 10 };
            double largest = num4[0];
            for (int i = 0; i < num4.Length; i++) { 
            if (num4[i] >largest){
                    largest = num4[i];
                }
            }
            Console.WriteLine("The Largest number is " + largest);

            //Calculation by input operators
            Console.Write("Enter number : ");
            double num5=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator : ");
            char opp=Convert.ToChar(Console.ReadLine());
            Console.Write("Enter another number : ");
            double num6 = Convert.ToDouble(Console.ReadLine());

            double reslt;

            switch (opp)
            {
                case '+':
                    reslt = num5 + num6;
                    Console.WriteLine("The sum is : "+reslt);
                    break;
                case '-':
                    reslt = num5 - num6;
                    Console.WriteLine("The substraction is : "+reslt);
                    break;
                case '*':
                    reslt = num5 * num6;
                    Console.WriteLine("The multiplication is : " + reslt);
                    break;
                case '/':
                    reslt = num5 / num6;
                    Console.WriteLine("The devision is : "+reslt);
                    break;
            }


            Console.ReadKey();
        }
    }
}
