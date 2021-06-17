using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
                
            int[] myIntArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < myIntArr.Length; i++)
            {
                myStack.Push(myIntArr[i].ToString());
            }
            

            while (true)
            {
                string[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                if (command[0].ToLower() == "end")
                {
                    break;
                }
                string instruction = command[0].ToLower();
                if (instruction == "add")
                {
                    int numberOne = int.Parse(command[1]);
                    int numberTwo = int.Parse(command[2]);
                    myStack.Push(numberOne.ToString());
                    myStack.Push(numberTwo.ToString());
                }
                else if ("remove" == instruction)
                {
                    int numberRemove = int.Parse(command[1]);
                    if (numberRemove >= myStack.Count)
                    {
                        continue;
                    }
                    for (int i = 0; i < numberRemove; i++)
                    {
                        myStack.Pop();
                    }
                }

                
            }
            int sum = myStack.Select(int.Parse)l
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
