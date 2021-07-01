using System;
using System.Collections.Generic;

namespace RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is second parts SETS

            HashSet<string> myFirstSet = new HashSet<string>();
            int howMany = int.Parse(Console.ReadLine());


            for (int i = 0; i < howMany; i++)
            {
                string commnand = Console.ReadLine();

                myFirstSet.Add(commnand);
            }

            foreach (var item in myFirstSet)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
