using System;
using System.Numerics;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger centuries = BigInteger.Parse(Console.ReadLine());

            BigInteger years = centuries * 100;
            BigInteger days = centuries * 36524;
            BigInteger hours = centuries * 876576;
            BigInteger minutes = centuries * 52594560;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
