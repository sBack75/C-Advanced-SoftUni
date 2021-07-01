using System;
using System.Collections.Generic;
using System.Linq;

namespace CitiesByContinentsAndCoutry
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> myList = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < howMany; i++)
            {
                string[] curData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string continet = curData[0];
                string country = curData[1];
                string cityes = curData[2];

                if (myList.ContainsKey(continet) == false)
                {
                    Dictionary<string, List<string>> curDic = new Dictionary<string, List<string>>();
                    List<string> ciy = new List<string>();
                    ciy.Add(cityes);
                    curDic.Add(country, ciy);
                    myList.Add(continet, curDic);
                }
                else if (!myList[continet].ContainsKey(country))
                {

                    myList[continet].Add(country, new List<string>());
                    myList[continet][country].Add(cityes);
                }

                else
                {
                    myList[continet][country].Add(cityes);
                }
               
            }

            foreach (var item in myList)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var secondImte in item.Value)
                {
                    Console.Write($"{secondImte.Key} -> ");

                   
                        Console.Write(string.Join(", ",secondImte.Value));
                    
                    Console.WriteLine();
                }
            }
        }
    }
}
