using System;
using System.Collections.Generic;
using System.Linq;

namespace SongQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songNames = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
            Queue<string> myQueue = new Queue<string>(songNames);
          
            do
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "Play")
                {
                    if (myQueue.Any())
                    {
                        myQueue.Dequeue();
                    }
                    else
                    {
                       // Console.WriteLine("No more songs!");
                        break;
                    }
                    
                }
                else if (command[0] == "Add")
                {
                    string curSongName = string.Empty;
                    for (int i = 1; i < command.Length; i++)
                    {
                        curSongName += command[i]+" ";
                    }
                    curSongName = curSongName.Trim();

                    if (myQueue.Contains(curSongName) == false)
                    {
                        myQueue.Enqueue(curSongName);
                    }
                    else
                    {
                        Console.WriteLine($"{curSongName} is already contained!");
                    }
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ",myQueue));
                }
            } while (myQueue.Any());
            Console.WriteLine("No more songs!");
        }
    }
}
