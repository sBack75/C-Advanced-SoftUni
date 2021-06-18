using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Queue<string> theGame = new Queue<string>(names);
            int counter = 0;
            int cutNumber = int.Parse(Console.ReadLine());
            

            while (true)
            {
                
                string curKid = theGame.Dequeue();
                counter++;
                if (counter == cutNumber)
                {
                    Console.WriteLine($"Removed {curKid}");
                    counter = 0;
                }
                else if (true)
                {
                    theGame.Enqueue(curKid);
                }

                if (theGame.Count <=1)
                {
                    break;
                }
            }
            foreach (var item in theGame)
            {
                Console.WriteLine($"Last is {item}");
            }
        }
    }
}
