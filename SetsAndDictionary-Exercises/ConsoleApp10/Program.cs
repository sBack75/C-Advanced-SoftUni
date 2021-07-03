using System;
using System.Collections.Generic;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < howMany; i++)
            {
                string curName = Console.ReadLine();

                names.Add(curName);
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
