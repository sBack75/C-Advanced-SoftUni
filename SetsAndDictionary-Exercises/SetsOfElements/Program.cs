using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberLenght = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int firstLenght = numberLenght[0];
            int secondLenght = numberLenght[1];

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int first = 0; first < firstLenght; first++)
            {
                int curNumber = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(curNumber))
                {
                    numbers.Add(curNumber,+1);
                }
                else
                {
                    numbers[curNumber] += 1;
                }

            }
            for (int second = 0; second < secondLenght; second++)
            {
                int curNumber = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(curNumber))
                {
                    numbers.Add(curNumber, +1);
                }
                else
                {
                    numbers[curNumber] += 1;
                }

            }
            numbers = numbers.Where(x => x.Value > 1).ToDictionary(y => y.Key, x => x.Value);

            Console.WriteLine(string.Join(' ',numbers.Keys));

        }
    }
}
