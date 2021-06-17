using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myFirstStack = new Stack<string>();
            char[] myArr = Console.ReadLine()
                .ToCharArray();

            for (int i = 0; i < myArr.Length; i++)
            {
                myFirstStack.Push(myArr[i].ToString());
            }

            Console.WriteLine(string.Join("",myFirstStack));
           
        }
    }
}
