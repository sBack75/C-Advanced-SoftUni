using System;
using System.Collections;
using System.Collections.Generic;

namespace MatchingBraking
{
    class Program
    {
        static void Main(string[] args)
        {

            // NOT SOLVING
            Stack<string> myStack = new Stack<string>();
            string prob = string.Empty;
            char[] problem = Console.ReadLine().ToCharArray();

            for (int i = 0; i < problem.Length; i++)
            {
                if (problem[i] == '(')
                {
                    int startIndex = i;

                    for (int s = startIndex; s < problem.Length; s++)
                    {
                        if (problem[s] == ')')
                        {
                            int endIndex = problem[s];

                            for (int th = startIndex; th < endIndex; th++)
                            {

                                prob = prob + problem[th];
                            }
                        }
                    }
                }
            }
        }
    }
}
