using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> stores = new SortedDictionary<string, Dictionary<string, double>>() ;

            while (true)
            {
                string[] curData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (curData[0] == "Revision")
                {
                    break;
                }
                string shopName = curData[0];
                string product = curData[1];
                double price = double.Parse(curData[2]);

               
                if (stores.ContainsKey(shopName)) 
                {
                    Dictionary<string, double> curInf = new Dictionary<string, double>();
                    curInf.Add(product, price);
                    stores[shopName].Add(product,price);
                }
                else
                {
                    Dictionary<string, double> curInf = new Dictionary<string, double>();
                    curInf.Add(product, price);
                    stores.Add(shopName , curInf);
                }

            }

            foreach (var item in stores)
            {
                Console.WriteLine($"{item.Key}->");

                foreach (var curIt in item.Value)
                {
                    Console.WriteLine($"Product: {curIt.Key} Price: {curIt.Value}");
                }
            }
        }
    }
}
