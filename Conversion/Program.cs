﻿using System;

namespace Conversion
{
     class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14;
            int m = Convert.ToInt32(n);
            Console.WriteLine(m);//display 3
            Console.WriteLine(n.GetType());//datatyp of n 
            Console.WriteLine(m.GetType());

            int a = 3;
            double b = Convert.ToDouble(a);
            Console.WriteLine(b);

            double c;
            Console.Write("Enter a double number: "); 
            c = Double.Parse(Console.ReadLine());

            Console.WriteLine("The double number is " + c);

            Console.Write("After convert into integr the number is: ");
            int d = Convert.ToInt32(c);
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
