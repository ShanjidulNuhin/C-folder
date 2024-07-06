using System;
using System.Text;

namespace RandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // Generating a random integer
            int num = random.Next(1, 10);
            Console.WriteLine(num);

            // Generating a random double
            double x = random.NextDouble() * (10.00 - 1.00) + 1.00;
            Console.WriteLine(x);

            // Generating a random string
            string m = GenerateRandomString(random, 10); 
            // Generating a 10 character long random string
            Console.WriteLine(m);

            Console.ReadKey();
        }

        static string GenerateRandomString(Random random, int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }
            return result.ToString();
        }
    }
}
