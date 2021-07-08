using System;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            double average = numbers.Average();

            int[] result = new int[5];
            result = numbers.Where(x => x > average).ToArray(); 
            result = result.OrderByDescending(x => x).ToArray();
            result = result.Take(5).ToArray();
            if (result.Length == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(' ', result));
            }
        } 
    }
}
