using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
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
            int[] allElements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> myQueue = new Queue<int>(allElements);
          

            for (int i = 0; i < s; i++)
            {
                myQueue.Dequeue();
            }

            if (myQueue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (myQueue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int minNum = myQueue.Min();
                Console.WriteLine(minNum);
            }
            myQueue
        }
    }
}
