using System;

namespace PoundToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());
             pound *= 1.31M;
            Console.WriteLine($"{pound:f3}");
        }
    }
}
