﻿using System;
namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.Write("Enter your name: ");
            name =  Console.ReadLine();
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("==============");
            Console.WriteLine("hi");
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is "+age);
            Console.WriteLine("============");
            double n,m;

            Console.Write("enter number: ");
            n= Double.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            m = Double.Parse(Console.ReadLine());
            double s = n + m;
            double sum = m * n;
            Console.WriteLine("the sum is "+s);
            Console.WriteLine("The multiplication is " + sum);           
            Console.ReadKey();
            
            
        }
    }
}
