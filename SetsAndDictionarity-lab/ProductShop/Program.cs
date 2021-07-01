using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shopsList = new Dictionary<string, Dictionary<string, double>>();


            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Revision")
                {
                    break;
                }
                string store = command[0];
                string product = command[1];
                double price = double.Parse(command[2]);

                if (!shopsList.ContainsKey(store))
                {
                    shopsList.Add(store, new Dictionary<string, double>());
                    shopsList[store].Add(product, price);
                }
                else if (shopsList.ContainsKey(store)) 
                {
                    shopsList[store].Add(product, price);
                }
            }

            foreach (var item in shopsList)
            {
                Console.WriteLine($"{item.Key} ->");

                Console.WriteLine(string.Join(' ',shopsList.Values));
            }
        }
    }
}
