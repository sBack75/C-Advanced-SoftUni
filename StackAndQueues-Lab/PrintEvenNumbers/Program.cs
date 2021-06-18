using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myFirstQueue = new Queue<int>();
            int[] myArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] % 2 == 0)
                {
                    myFirstQueue.Enqueue(myArr[i]);
                }
            }

            Console.WriteLine(string.Join(", ",myFirstQueue));

        }
    }
}
