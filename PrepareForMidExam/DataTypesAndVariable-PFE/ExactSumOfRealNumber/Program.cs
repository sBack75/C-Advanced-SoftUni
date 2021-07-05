using System;
using System.Numerics;

namespace ExactSumOfRealNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            decimal result = new decimal();
            for (int i = 0; i < howMany; i++)
            {

                decimal curData = decimal.Parse(Console.ReadLine());
                result += curData;
            }
            Console.WriteLine(result);
        }
    }
}
