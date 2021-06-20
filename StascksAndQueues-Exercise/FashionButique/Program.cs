using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionButique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesFromBox = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> myStack = new Stack<int>(clothesFromBox);
            clothesFromBox = clothesFromBox.Reverse().ToArray();
            int rackCounter = 0;
            List<int> racks = new List<int>();
            racks.Add(rackCapacity);
            for (int i = 0; i < clothesFromBox.Length; i++)
            {
                int curNum = clothesFromBox[i];
                if (racks[racks.Count-1] - clothesFromBox[i] <= 0 )
                {
                    racks.Add(rackCapacity);
                    racks[racks.Count - 1] -= clothesFromBox[i];
                    rackCounter++;
                    myStack.Pop();
                }
                else
                {
                    racks[racks.Count - 1] -= clothesFromBox[i];
                    myStack.Pop();
                }
            }
            Console.WriteLine(racks.Count);
        }
    }
}
