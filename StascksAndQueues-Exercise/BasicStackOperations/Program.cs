using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NSX = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = NSX[0];
            int s = NSX[1];
            int x = NSX[2];

            int[] elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> sequence = new Stack<int>(elements);

            for (int i = 0; i < s; i++)
            {
                sequence.Pop();
            }

            if (sequence.Contains(x))
            {
                Console.WriteLine("true");
            }
            
            else if (sequence.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(sequence.Pop());
            }
        }
    }
}
