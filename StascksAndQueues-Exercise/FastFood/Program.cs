using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int myFood = int.Parse(Console.ReadLine());
            int[] clientDemands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> demands = new Queue<int>(clientDemands);
            if (clientDemands.Any())
            {
                int mostBigDemand = clientDemands.Max();
                Console.WriteLine(mostBigDemand);
            }

            for (int i = 0; i < clientDemands.Length; i++)
            {
               

                if (myFood - clientDemands[i] >= 0)
                {
                    myFood -= clientDemands[i];
                    demands.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(' ',demands)}");
                    break;
                }
            }

            if (demands.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
