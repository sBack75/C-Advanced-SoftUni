using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            Stack<int> myStack = new Stack<int>();


            for (int i = 0; i < howMany; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                
                if (command[0] == "1")
                {
                    int number = int.Parse(command[1]);
                    myStack.Push(number);
                }
                else if (command[0] == "2")
                {
                    if (myStack.Any() == true)
                    {
                        myStack.Pop();
                    }
                }
                else if (command[0] == "3")
                {
                    if (myStack.Any())
                    {
                        int maxNum = myStack.Max();
                        Console.WriteLine(maxNum);
                    }
                }
                else if (command[0] == "4")
                {
                    if (myStack.Any())
                    {
                        int minNum = myStack.Min();
                        Console.WriteLine(minNum);
                    }
                }
            }
            Console.WriteLine(string.Join(", ",myStack));
        }
    }
}
