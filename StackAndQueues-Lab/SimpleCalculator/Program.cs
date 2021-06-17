using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();

            string[] exercise = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = exercise.Length-1; i >= 0; i--)
            {
                myStack.Push(exercise[i]);
            }
            
            while (myStack.Count >=3)
            {
                int numberOne = int.Parse(myStack.Pop());
                string operand = myStack.Pop();
                int numberTwo = int.Parse(myStack.Pop());
               
                if (operand == "+")
                {
                    int result = numberOne + numberTwo;
                    myStack.Push(result.ToString());
                }
                else if (operand == "-")
                {
                    int result = numberOne - numberTwo;
                    myStack.Push(result.ToString());
                }

            }
            int sum = myStack.Select(int.Parse).Sum();
            Console.WriteLine(sum);
        }
    }
}
