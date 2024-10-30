using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        public static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Inside the methode "+x +" and "+y);
        }
      public static  void Calculation(int x , int y, out int ad,out int sub,out int mul, out int div)
        {
            ad = x + y;
            sub=x-y;
            mul = x * y;
            div = y / y;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter two integer number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int addition, substraction, multiplication, division;

           
            Console.WriteLine("Before calling method "+ num1 +" and "+num2);
            swap(ref num1, ref num2);

            Calculation(num1, num2, out addition, out substraction, out multiplication, out division);

            Console.WriteLine("The addition is= "+ addition);
            Console.WriteLine("The substraction is " + substraction);
            Console.WriteLine("The multiplication is= " + multiplication);
            Console.WriteLine("The division is= " + division);
            Console.ReadKey();
        }
    }
}
