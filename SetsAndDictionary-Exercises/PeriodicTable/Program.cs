using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            SortedDictionary<string, int> chemicalElements = new SortedDictionary<string, int>();

            for (int i = 0; i < numberOfElements; i++)
            {
                string[] curElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int s = 0; s < curElements.Length; s++)
                {
                    if (!chemicalElements.ContainsKey(curElements[s]))
                    {
                        chemicalElements.Add(curElements[s], +1);
                    }
                    else
                    {
                        chemicalElements[curElements[s]] += 1;
                    }
                }
            }

           // chemicalElements = chemicalElements.Where(x => x.Value > 1).ToDictionary(p => p.Key, x => x.Value);

            Console.WriteLine(string.Join(' ',chemicalElements.Keys));
        }
    }
}
