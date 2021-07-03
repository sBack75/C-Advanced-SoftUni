using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();


            for (int i = 0; i < howMany; i++)
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

            numbers = numbers.Where(x => x.Value % 2 == 0).ToDictionary(p => p.Key, x => x.Value);

            Console.WriteLine(string.Join(' ',numbers.Keys));
           
            
        }
    }
}
