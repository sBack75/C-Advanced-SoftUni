using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValueInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> counter = new Dictionary<double, int>();

            double[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (counter.ContainsKey(numbers[i]) == false)
                {
                    counter.Add(numbers[i],0);
                }

                counter[numbers[i]]++;
                 
            }
            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
