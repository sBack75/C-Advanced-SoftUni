using System;
using System.Collections.Generic;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> people = new Queue<string>();
            int counter = 0;


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                else if (command == "Paid")
                {
                    int count = people.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(people.Dequeue());
                        counter++;
                    }
                }
                else
                {
                    people.Enqueue(command);
                }
            }
            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}
