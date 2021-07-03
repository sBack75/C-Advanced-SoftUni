using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine()
                 .ToCharArray();
            SortedDictionary<char, int> symbolsNumbers = new SortedDictionary<char, int>();

            for (int  i = 0;  i< word.Length; i++)
            {
                if (!symbolsNumbers.ContainsKey(word[i]))
                {
                    symbolsNumbers.Add(word[i], +1);
                }
                else
                {
                    symbolsNumbers[word[i]] += 1;
                }
            }

            foreach (var item in symbolsNumbers)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
                
        }
    }
}
